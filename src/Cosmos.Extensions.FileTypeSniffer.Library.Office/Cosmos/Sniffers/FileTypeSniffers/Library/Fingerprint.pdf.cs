using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("pdf")]
    [FileTypeHex("25 50 44 46")]
    public class _Pdf_Fingerprint : IFileTypeFingerprint { }
}