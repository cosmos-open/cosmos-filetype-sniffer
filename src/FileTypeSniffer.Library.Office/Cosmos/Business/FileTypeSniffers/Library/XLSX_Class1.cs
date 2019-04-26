using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("xlsx")]
    [FileTypeHex("50,4b,03,04")]
    [FileTypeDescription("Microsoft Office Excel OOXML file")]
    public class XLSX_Class1 : IFileTypeRegistrar { }
}