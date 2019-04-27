using System;
using System.Collections.Generic;
using System.Linq;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Core.Extensions
{
    internal static class CharExtensions
    {
        public static char[] Join(this char[] left, char[] right)
        {
            if (left == null)
                throw new ArgumentNullException(nameof(left));

            if (right == null || !right.Any())
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
