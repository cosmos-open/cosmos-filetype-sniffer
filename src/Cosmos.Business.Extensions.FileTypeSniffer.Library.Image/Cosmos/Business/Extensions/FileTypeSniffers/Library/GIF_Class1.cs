using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("gif")]
    [FileTypeHex("47 49 46 38 37 61")]
    public class GIF_Class1 : IFileTypeRegistrar { }
}