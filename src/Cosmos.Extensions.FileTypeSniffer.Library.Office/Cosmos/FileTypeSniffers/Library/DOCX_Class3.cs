using Cosmos.FileTypeSniffers.Registering;

namespace Cosmos.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("docx")]
    [FileTypeHex("50,4b,05,06")]
    [FileTypeDescription("Microsoft Office Word OOXML file")]
    public class DOCX_Class3 : IFileTypeRegistrar { }
}