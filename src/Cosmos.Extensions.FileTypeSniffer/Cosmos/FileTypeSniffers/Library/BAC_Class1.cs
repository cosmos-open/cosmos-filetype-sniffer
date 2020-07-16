using Cosmos.FileTypeSniffers.Registering;

namespace Cosmos.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("bac")]
    [FileTypeHex("42 41 43 4B 4D 49 4B 45 44 49 53 4B")]
    public class BAC_Class1 : IFileTypeRegistrar { }
}