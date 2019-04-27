using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("wmv")]
    [FileTypeHex("30 26 B2 75 8E 66 CF 11 A6 D9 00 AA 00 62 CE 6C")]
    public class WMV_Class1 : IFileTypeRegistrar { }
}