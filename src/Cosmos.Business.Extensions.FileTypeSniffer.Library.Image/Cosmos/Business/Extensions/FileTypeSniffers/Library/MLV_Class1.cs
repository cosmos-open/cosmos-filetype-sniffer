using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("mlv")]
    [FileTypeHex("4D 4C 56 49")]
    public class MLV_Class1 : IFileTypeRegistrar { }
}