using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("pptx")]
    [FileTypeHex("50,4b,05,06")]
    [FileTypeDescription("Microsoft Office PowerPoint OOXML file")]
    public class PPTX_Class3 : IFileTypeRegistrar { }
}