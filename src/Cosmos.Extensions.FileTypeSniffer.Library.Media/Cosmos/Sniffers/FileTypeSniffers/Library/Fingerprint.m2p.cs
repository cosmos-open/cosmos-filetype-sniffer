using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("m2p,mpg2")]
    [FileTypeHex("00 00 01 BA")]
    public class _M2p_Fingerprint : IFileTypeFingerprint { }
}