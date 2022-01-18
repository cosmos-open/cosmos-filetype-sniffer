using System;
using System.Collections.Generic;
using System.Linq;

namespace CosmosStack.Sniffers.FileTypeSniffers.Core
{
    internal static class SniffingNodeExtensions
    {
        public static List<string> Match(this SniffingNode currentNode, int depth, byte[] data, bool matchAll = false)
        {
            var ret = new List<string>();
            Match(data, depth, currentNode, ret, matchAll);
            return ret;
        }

        private static void Match(byte[] data, int depth, SniffingNode node, List<string> store, bool matchAll)
        {
            //如果 depth 的值（即节点深度）超出 data 长度，结束迭代匹配
            if (depth == data.Length)
                return;

            node.Children.TryGetValue(data[depth], out var current);

            //如果 current 节点为 null，表示未命中节点，结束迭代匹配
            if (current == null)
                return;

            //如果 current 节点的扩展名清单不为空，记录结果
            if (current.ExtensionNames != null)
            {
                store.AddRange(current.ExtensionNames);
                if (!matchAll) return;
            }

            //Children 为空，不再继续迭代，结束匹配
            if (current.Children == null)
                return;

            Match(data, depth + 1, current, store, matchAll);
        }

        public static void Update(this SniffingNode parent, IReadOnlyList<byte> data, IReadOnlyList<string> extensionNames, int depth)
        {
            Update(parent, data.ToArray(), extensionNames.ToArray(), depth);
        }

        private static void Update(SniffingNode parent, byte[] data, string[] extensionNames, int depth)
        {
            SniffingNode current;

            if (parent.Children == null)
            {
                parent.Children = new SortedList<byte, SniffingNode>(Convert.ToInt32(128 / Math.Pow(2, depth)));
            }

            //如果子节点内不包含指定的 byte 索引，则创建相应子节点至 Children
            if (!parent.Children.ContainsKey(data[depth]))
            {
                current = new SniffingNode(parent, depth);
                parent.Children.Add(data[depth], current);
            }
            else
            {
                if (!parent.Children.TryGetValue(data[depth], out current))
                {
                    throw new InvalidOperationException($"Invalid operation: cannot find value for '{data[depth]}', depth = {depth}.");
                }
            }

            //最后一位判断
            if (depth == (data.Length - 1))
            {
                if (current.ExtensionNames == null)
                {
                    current.ExtensionNames = new List<string>(4);
                }

                current.ExtensionNames.AddRange(extensionNames);

                return;
            }

            Update(current, data, extensionNames, depth + 1);
        }
    }
}
