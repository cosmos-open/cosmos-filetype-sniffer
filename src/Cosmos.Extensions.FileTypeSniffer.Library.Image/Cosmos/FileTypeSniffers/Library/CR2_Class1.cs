using Cosmos.FileTypeSniffers.Registering;

namespace Cosmos.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("cr2")]
    [FileTypeHex("49 49 2A 00 10 00 00 00 43 52")]
    [FileTypeDescription("佳能 Canon 单反相机格式化")]
    public class CR2_Class1 : IFileTypeRegistrar { }
}