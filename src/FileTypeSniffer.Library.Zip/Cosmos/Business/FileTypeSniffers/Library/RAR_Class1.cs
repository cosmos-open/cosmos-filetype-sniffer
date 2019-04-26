using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("rar")]
    [FileTypeHex("52,61,72,21,1a,07,00")]
    public class RAR_Class1 : IFileTypeRegistrar { }
}