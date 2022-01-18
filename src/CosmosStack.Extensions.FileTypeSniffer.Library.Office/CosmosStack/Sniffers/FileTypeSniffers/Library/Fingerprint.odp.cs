using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("odp")]
    [FileTypeHex("50,4b,03,04")]
    [FileTypeDescription("OpenDocument Presentation")]
    public class _Odp_1_Fingerprint : IFileTypeFingerprint { }
    
    [FileTypeExtensionNames("odp")]
    [FileTypeHex("50,4b,07,08")]
    [FileTypeDescription("OpenDocument Presentation")]
    public class _Odp_2_Fingerprint : IFileTypeFingerprint { }

    [FileTypeExtensionNames("odp")]
    [FileTypeHex("50,4b,05,06")]
    [FileTypeDescription("OpenDocument Presentation")]
    public class _Odp_3_Fingerprint : IFileTypeFingerprint { }
}