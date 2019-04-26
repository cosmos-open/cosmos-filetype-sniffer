using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("docx")]
    [FileTypeHex("50,4b,03,04")]
    [FileTypeDescription("Microsoft Office Word OOXML file")]
    public class DOCX_Class1 : IFileTypeRegistrar { }
}