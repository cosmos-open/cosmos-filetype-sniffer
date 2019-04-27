using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("xlsx")]
    [FileTypeHex("50,4b,07,08")]
    [FileTypeDescription("Microsoft Office Excel OOXML file")]
    public class XLSX_Class2 : IFileTypeRegistrar { }
}