using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("rar")]
    [FileTypeHex("52,61,72,21,1a,07,01,00")]
    public class RAR_Class2 : IFileTypeRegistrar { }
}