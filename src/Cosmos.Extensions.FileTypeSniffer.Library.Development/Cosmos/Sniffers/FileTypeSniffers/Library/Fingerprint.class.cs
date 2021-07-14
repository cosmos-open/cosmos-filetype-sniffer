using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("class")]
    [FileTypeHex("CA FE BA BE")]
    public class _Class_Fingerprint : IFileTypeFingerprint { }
}