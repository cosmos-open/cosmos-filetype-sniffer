using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("lzfse")]
    [FileTypeHex("62 76 78 32")]
    public class LZFSE_Class1 : IFileTypeRegistrar { }
}