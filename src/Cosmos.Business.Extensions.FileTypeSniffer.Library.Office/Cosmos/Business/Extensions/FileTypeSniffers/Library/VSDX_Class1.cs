using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("vsdx")]
    [FileTypeHex("50,4b,03,04")]
    [FileTypeDescription("Microsoft Office Visio file")]
    public class VSDX_Class1 : IFileTypeRegistrar { }
}