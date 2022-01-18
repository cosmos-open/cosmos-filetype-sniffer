using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("der")]
    [FileTypeHex("30 82")]
    public class _Der_Fingerprint : IFileTypeFingerprint { }
}