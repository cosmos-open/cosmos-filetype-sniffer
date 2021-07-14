using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("mkv mka mks mk3d")]
    [FileTypeHex("1A 45 DF A3")]
    public class _Mkv_Fingerprint : IFileTypeFingerprint { }
}