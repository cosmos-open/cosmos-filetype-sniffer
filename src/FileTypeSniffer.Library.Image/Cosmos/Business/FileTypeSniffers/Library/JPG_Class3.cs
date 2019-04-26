using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("jpg,jpeg")]
    [FileTypeHex("ff,d8,ff,db")]
    public class JPG_Class3 : IFileTypeRegistrar { }
}
