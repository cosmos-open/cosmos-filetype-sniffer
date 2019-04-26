using System;

namespace Cosmos.Business.FileTypeSniffers.Registering
{
    [AttributeUsage(AttributeTargets.Class)]
    public class FileTypeDescriptionAttribute : Attribute
    {
        public FileTypeDescriptionAttribute(string description)
        {
            Description = description;
        }

        public string Description { get; }
    }
}
