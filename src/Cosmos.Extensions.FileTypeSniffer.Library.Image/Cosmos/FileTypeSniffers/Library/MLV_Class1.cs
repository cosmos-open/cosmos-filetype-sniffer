using Cosmos.FileTypeSniffers.Registering;

namespace Cosmos.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("mlv")]
    [FileTypeHex("4D 4C 56 49")]
    public class MLV_Class1 : IFileTypeRegistrar { }
}