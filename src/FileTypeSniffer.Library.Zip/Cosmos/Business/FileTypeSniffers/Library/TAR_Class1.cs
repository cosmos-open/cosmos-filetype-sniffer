using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("tar")]
    [FileTypeHex("75 73 74 61 72")]
    [FileTypeOffset(257)]
    public class TAR_Class1 : IFileTypeRegistrar { }
}