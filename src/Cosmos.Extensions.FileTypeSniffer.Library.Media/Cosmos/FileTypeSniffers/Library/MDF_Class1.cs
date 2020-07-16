using Cosmos.FileTypeSniffers.Registering;

namespace Cosmos.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("mdf")]
    [FileTypeHex("00 FF FF FF FF FF FF FF FF FF FF 00 00 02 00 01")]
    public class MDF_Class1 : IFileTypeRegistrar { }
}