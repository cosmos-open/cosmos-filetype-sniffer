using System;

namespace CosmosStack.Sniffers.FileTypeSniffers.Registering
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
