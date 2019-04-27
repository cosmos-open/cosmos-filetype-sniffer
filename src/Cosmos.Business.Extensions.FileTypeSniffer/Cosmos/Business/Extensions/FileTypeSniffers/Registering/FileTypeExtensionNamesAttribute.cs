using System;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Registering
{
    [AttributeUsage(AttributeTargets.Class)]
    public class FileTypeExtensionNamesAttribute : Attribute
    {
        public FileTypeExtensionNamesAttribute(string extensionNames)
        {
            ExtensionNames = extensionNames;
        }

        public string ExtensionNames { get; }
    }
}
