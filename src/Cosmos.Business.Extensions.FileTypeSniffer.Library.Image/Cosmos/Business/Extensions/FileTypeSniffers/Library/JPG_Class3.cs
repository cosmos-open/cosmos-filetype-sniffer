using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("jpg,jpeg")]
    [FileTypeHex("ff,d8,ff,db")]
    public class JPG_Class3 : IFileTypeRegistrar { }
}
