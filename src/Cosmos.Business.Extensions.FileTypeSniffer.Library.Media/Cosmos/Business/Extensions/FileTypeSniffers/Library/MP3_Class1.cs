using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("mp3")]
    [FileTypeHex("FF FB")]
    public class MP3_Class1 : IFileTypeRegistrar { }
}