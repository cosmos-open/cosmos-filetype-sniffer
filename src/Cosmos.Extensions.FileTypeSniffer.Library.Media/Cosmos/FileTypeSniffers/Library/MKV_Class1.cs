using Cosmos.FileTypeSniffers.Registering;

namespace Cosmos.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("mkv mka mks mk3d")]
    [FileTypeHex("1A 45 DF A3")]
    public class MKV_Class1 : IFileTypeRegistrar { }
}