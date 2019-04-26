using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("flif")]
    [FileTypeHex("46 4C 49 46")]
    public class FLIF_Class1 : IFileTypeRegistrar { }
}