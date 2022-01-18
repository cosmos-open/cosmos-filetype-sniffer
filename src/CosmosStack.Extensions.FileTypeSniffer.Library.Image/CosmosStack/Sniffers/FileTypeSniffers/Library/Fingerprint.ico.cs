using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("ico")]
    [FileTypeHex("00 00 01 00")]
    public class _Ico_Fingerprint : IFileTypeFingerprint { }
}