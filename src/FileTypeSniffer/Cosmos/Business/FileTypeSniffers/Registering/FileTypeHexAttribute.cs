using System;

namespace Cosmos.Business.FileTypeSniffers.Registering
{
    [AttributeUsage(AttributeTargets.Class)]
    public class FileTypeHexAttribute : Attribute
    {
        public FileTypeHexAttribute(string hex)
        {
            Hex = hex;
        }

        public string Hex { get; }
    }
}
