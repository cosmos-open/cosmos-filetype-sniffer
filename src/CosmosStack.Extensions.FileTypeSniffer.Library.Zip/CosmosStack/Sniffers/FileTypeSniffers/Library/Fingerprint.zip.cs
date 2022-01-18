using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("zip")]
    [FileTypeHex("50,4b,03,04")]
    public class _Zip_1_Fingerprint : IFileTypeFingerprint { }

    [FileTypeExtensionNames("zip")]
    [FileTypeHex("50,4b,07,08")]
    public class _Zip_2_Fingerprint : IFileTypeFingerprint { }

    [FileTypeExtensionNames("zip")]
    [FileTypeHex("50,4b,05,06")]
    public class _Zip_3_Fingerprint : IFileTypeFingerprint { }
}