using System;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Registering
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
