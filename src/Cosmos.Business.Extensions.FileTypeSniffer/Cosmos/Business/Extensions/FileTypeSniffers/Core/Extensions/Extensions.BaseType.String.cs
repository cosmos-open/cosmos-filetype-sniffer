using System;
using System.Text;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Core.Extensions
{
    internal static class StringExtensions
    {
        public static string Repeat(this string source, int times, char separator)
        {
            if (times <= 0)
                return source;

            var capacity = (source + separator).Length * times;
            var builder = new StringBuilder(capacity);

            for (var i = 0; i < times; i++)
                builder.Append(source).Append(separator);

            return builder.ToString();
        }

        public static byte[] GetByte(this string source)
        {
            var array = source.Split(',', ' ');
            var byteArr = new byte[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                byteArr[i] = Convert.ToByte(array[i], 16);
            }

            return byteArr;
        }

        public static string RemoveDotAtFirstPosition(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return string.Empty;

            return str.StartsWith(".") ? str.Substring(1) : str;
        }

    }
}
