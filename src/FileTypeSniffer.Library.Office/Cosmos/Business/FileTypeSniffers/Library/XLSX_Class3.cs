using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("xlsx")]
    [FileTypeHex("50,4b,05,06")]
    [FileTypeDescription("Microsoft Office Excel OOXML file")]
    public class XLSX_Class3 : IFileTypeRegistrar { }
}