using Cosmos.FileTypeSniffers.Registering;

namespace Cosmos.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("jpg,jpeg")]
    [FileTypeHex("FF D8 FF E1 ?? ?? 45 78 69 66 00 00")]
    public class JPG_Class2 : IFileTypeRegistrar { }
}
