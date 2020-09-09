using System;
using System.Collections.Generic;
using System.Linq;

namespace Cosmos.FileTypeSniffers.Core
{
    internal static class CharExtensions
    {
        public static char[] Join(this char[] left, char[] right)
        {
            if (left is null)
                throw new ArgumentNullException(nameof(left));

            if (right is null || !right.Any())
                return left;

            var list = new List<char>(left);
            foreach (var @char in right)
            {
                if (list.Contains(@char))
                    continue;
                list.Add(@char);
            }

            return list.ToArray();
        }
    }
}