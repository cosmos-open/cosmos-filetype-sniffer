using Cosmos.FileTypeSniffers.Registering;

namespace Cosmos.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("ico")]
    [FileTypeHex("00 00 01 00")]
    public class ICO_Class1 : IFileTypeRegistrar { }
}