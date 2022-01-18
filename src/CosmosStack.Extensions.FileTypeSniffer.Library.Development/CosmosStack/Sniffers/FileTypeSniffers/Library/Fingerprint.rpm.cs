using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("rpm")]
    [FileTypeHex("ed ab ee db")]
    public class _Rpm_Fingerprint : IFileTypeFingerprint { }
}