using System;

namespace CosmosStack.Sniffers.FileTypeSniffers.Registering
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
