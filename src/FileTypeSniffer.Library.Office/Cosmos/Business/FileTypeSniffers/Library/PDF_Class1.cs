using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("pdf")]
    [FileTypeHex("25 50 44 46")]
    public class PDF_Class1 : IFileTypeRegistrar { }
}