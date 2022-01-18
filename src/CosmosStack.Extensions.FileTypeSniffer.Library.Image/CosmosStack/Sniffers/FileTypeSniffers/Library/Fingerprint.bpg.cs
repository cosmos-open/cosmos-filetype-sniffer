using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("bpg")]
    [FileTypeHex("42 50 47 FB")]
    public class _Bpg_Fingerprint : IFileTypeFingerprint { }
}