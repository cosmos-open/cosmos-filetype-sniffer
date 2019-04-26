using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("mp3")]
    [FileTypeHex("FF FB")]
    public class MP3_Class1 : IFileTypeRegistrar { }
}