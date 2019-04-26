using System;

namespace Cosmos.Business.FileTypeSniffers.Registering
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
