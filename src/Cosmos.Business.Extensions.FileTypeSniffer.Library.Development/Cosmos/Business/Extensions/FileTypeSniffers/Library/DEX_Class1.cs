using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("dex")]
    [FileTypeHex("64 65 78 0A 30 33 35 00")]
    public class DEX_Class1 : IFileTypeRegistrar { }
}