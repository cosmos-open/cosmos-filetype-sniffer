using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Cosmos.Business.FileTypeSniffers.Core.Extensions;

namespace Cosmos.Business.FileTypeSniffers.Registering
{
    public class FileTypeDescriptor : IFileTypeDescriptor
    {
        public FileTypeDescriptor(Type registrarType)
        {
            CheckType(registrarType);

            Description = GetDescription(registrarType);
            ExtensionNames = GetExtensionNames(registrarType);
            Hex = GetHex(registrarType);
            Offset = GetOffset(registrarType);
        }

        public string Description { get; }

        public string ExtensionNames { get; }

        public List<string> ResolveExtensionNames(char[] separators)
        {
            if (string.IsNullOrWhiteSpace(ExtensionNames.Trim()))
                return Enumerable.Empty<string>().ToList();
            if (separators == null || !separators.Any())
                separators = new[] { ',', ' ' };
            return ExtensionNames.Split(separators).ToList();
        }

        public string Hex { get; }

        public int Offset { get; }

        public string[] ResolveHex(string source, char[] separators)
        {
            var hex = Offset > 0
                ? $"{source.Repeat(Offset, ',')}{Hex}"
                : Hex;

            return hex.Split(separators);
        }

        public bool IsComplexMetadata => Offset > 0 || Hex.Contains("?");

        private void CheckType(Type type)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type));

            if (!type.IsAssignableFrom(typeof(IFileTypeRegistrar)))
                throw new ArgumentException($"Type {type} cannot be assignable from {typeof(IFileTypeRegistrar)}", nameof(type));
        }

        private string GetDescription(Type type)
        {
            var descAttr = GetAttribute<FileTypeDescriptionAttribute>(type);
            return descAttr?.Description ?? string.Empty;
        }

        private string GetExtensionNames(Type type)
        {
            var extNameAttr = GetAttribute<FileTypeExtensionNamesAttribute>(type);
            return extNameAttr?.ExtensionNames ?? string.Empty;
        }

        private string GetHex(Type type)
        {
            var hexAttr = GetAttribute<FileTypeHexAttribute>(type);
            return hexAttr?.Hex ?? string.Empty;
        }

        private int GetOffset(Type type)
        {
            var offsetAttr = GetAttribute<FileTypeOffsetAttribute>(type);
            return offsetAttr?.Offset ?? 0;
        }

        private TAttribute GetAttribute<TAttribute>(Type type) where TAttribute : Attribute
        {
            return (TAttribute)type.GetCustomAttribute(typeof(TAttribute));
        }
    }
}
