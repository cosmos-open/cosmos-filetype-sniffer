using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("epub")]
    [FileTypeHex("50 4B 03 04 14 00 00 00 00 00 ?? ?? ?? ?? 6F 61")]
    public class _Epub_1_Fingerprint : IFileTypeFingerprint { }
    
    [FileTypeExtensionNames("epub")]
    [FileTypeHex("50 4B 03 04 0A 00 00 00 00 00 ?? ?? ?? ?? 6F 61")]
    public class _Epub_2_Fingerprint : IFileTypeFingerprint { }
}