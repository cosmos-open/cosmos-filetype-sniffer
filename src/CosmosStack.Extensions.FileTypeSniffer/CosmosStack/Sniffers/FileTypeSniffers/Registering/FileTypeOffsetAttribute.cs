using System;

namespace CosmosStack.Sniffers.FileTypeSniffers.Registering
{
    [AttributeUsage(AttributeTargets.Class)]
    public class FileTypeOffsetAttribute : Attribute
    {
        public FileTypeOffsetAttribute(int offset)
        {
            Offset = offset;
        }

        public int Offset { get; }
    }
}
