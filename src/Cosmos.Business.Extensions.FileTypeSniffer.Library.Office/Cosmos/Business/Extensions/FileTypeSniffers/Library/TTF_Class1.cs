using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("ttf")]
    [FileTypeHex("00 01 00 00 00")]
    public class TTF_Class1 : IFileTypeRegistrar { }
}