using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("mp3")]
    [FileTypeHex("49 44 33")]
    public class MP3_Class2 : IFileTypeRegistrar { }
}