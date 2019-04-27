using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("ods")]
    [FileTypeHex("50,4b,03,04")]
    [FileTypeDescription("OpenDocument Sheet")]
    public class ODS_Class1 : IFileTypeRegistrar { }
}