using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("pptx")]
    [FileTypeHex("50,4b,07,08")]
    [FileTypeDescription("Microsoft Office PowerPoint OOXML file")]
    public class PPTX_Class2 : IFileTypeRegistrar { }
}