using Cosmos.FileTypeSniffers.Registering;

namespace Cosmos.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("docx")]
    [FileTypeHex("50,4b,07,08")]
    [FileTypeDescription("Microsoft Office Word OOXML file")]
    public class DOCX_Class2 : IFileTypeRegistrar { }
}