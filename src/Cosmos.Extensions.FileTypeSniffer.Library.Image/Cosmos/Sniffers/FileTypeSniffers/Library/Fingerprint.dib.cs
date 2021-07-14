using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("dib")]
    [FileTypeHex("42 4D")]
    public class _Dib_Fingerprint : IFileTypeFingerprint { }
}