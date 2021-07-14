using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("vob")]
    [FileTypeHex("00 00 01 BA")]
    public class _Vob_Fingerprint : IFileTypeFingerprint { }
}