using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("png")]
    [FileTypeHex("89,50,4e,47,0d,0a,1a,0a")]
    public class _Png_Fingerprint : IFileTypeFingerprint { }
}
