using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("vob")]
    [FileTypeHex("00 00 01 BA")]
    public class _Vob_Fingerprint : IFileTypeFingerprint { }
}