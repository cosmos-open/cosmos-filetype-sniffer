using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("pdf")]
    [FileTypeHex("25 50 44 46")]
    public class _Pdf_Fingerprint : IFileTypeFingerprint { }
}