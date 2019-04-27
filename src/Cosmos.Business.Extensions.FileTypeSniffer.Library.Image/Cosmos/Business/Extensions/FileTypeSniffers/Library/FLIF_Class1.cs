using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("flif")]
    [FileTypeHex("46 4C 49 46")]
    public class FLIF_Class1 : IFileTypeRegistrar { }
}