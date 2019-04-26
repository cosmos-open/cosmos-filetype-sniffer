using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("wma")]
    [FileTypeHex("30 26 B2 75 8E 66 CF 11 A6 D9 00 AA 00 62 CE 6C")]
    public class WMA_Class1 : IFileTypeRegistrar { }
}