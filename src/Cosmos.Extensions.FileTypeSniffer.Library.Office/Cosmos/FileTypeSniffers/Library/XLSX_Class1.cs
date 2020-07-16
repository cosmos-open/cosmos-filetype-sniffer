using Cosmos.FileTypeSniffers.Registering;

namespace Cosmos.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("xlsx")]
    [FileTypeHex("50,4b,03,04")]
    [FileTypeDescription("Microsoft Office Excel OOXML file")]
    public class XLSX_Class1 : IFileTypeRegistrar { }
}