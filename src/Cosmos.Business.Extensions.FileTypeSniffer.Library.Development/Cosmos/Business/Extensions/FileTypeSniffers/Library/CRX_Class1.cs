using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("crx")]
    [FileTypeHex("43 72 32 34")]
    [FileTypeDescription("Google Chrome extensions file")]
    public class CRX_Class1 : IFileTypeRegistrar { }
}