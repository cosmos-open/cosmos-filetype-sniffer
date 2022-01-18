using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("apk")]
    [FileTypeHex("50,4b,03,04")]
    public class _Apk_1_Fingerprint : IFileTypeFingerprint { }
    
    [FileTypeExtensionNames("apk")]
    [FileTypeHex("50,4b,07,08")]
    public class _Apk_2_Fingerprint : IFileTypeFingerprint { }
    
    [FileTypeExtensionNames("apk")]
    [FileTypeHex("50,4b,05,06")]
    public class _Apk_3_Fingerprint : IFileTypeFingerprint { }
}