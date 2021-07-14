using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("dmg")]
    [FileTypeHex("78 01 73 0D 62 62 60")]
    public class _Dmg_Fingerprint : IFileTypeFingerprint { }
}