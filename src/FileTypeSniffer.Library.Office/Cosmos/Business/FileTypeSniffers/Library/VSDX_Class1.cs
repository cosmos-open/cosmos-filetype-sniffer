using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("vsdx")]
    [FileTypeHex("50,4b,03,04")]
    [FileTypeDescription("Microsoft Office Visio file")]
    public class VSDX_Class1 : IFileTypeRegistrar { }
}