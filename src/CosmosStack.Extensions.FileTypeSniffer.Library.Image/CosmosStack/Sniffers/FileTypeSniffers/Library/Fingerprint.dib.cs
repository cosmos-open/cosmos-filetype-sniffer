using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("dib")]
    [FileTypeHex("42 4D")]
    public class _Dib_Fingerprint : IFileTypeFingerprint { }
}