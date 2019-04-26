using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("jpg,jpeg")]
    [FileTypeHex("FF D8 FF E0 ?? ?? 4A 46 49 46 00 01")]
    public class JPG_Class1 : IFileTypeRegistrar { }
}
