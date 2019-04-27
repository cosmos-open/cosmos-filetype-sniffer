using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("pptx")]
    [FileTypeHex("50,4b,03,04")]
    [FileTypeDescription("Microsoft Office PowerPoint OOXML file")]
    public class PPTX_Class1 : IFileTypeRegistrar { }
}