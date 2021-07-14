using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("cwk")]
    [FileTypeHex("05 07 00 00 42 4F 42 4F 05 07 00 00 00 00 00 00 00 00 00 00 00 01")]
    public class _Cwk_1_Fingerprint : IFileTypeFingerprint { }
    
    [FileTypeExtensionNames("cwk")]
    [FileTypeHex("06 07 E1 00 42 4F 42 4F 06 07 E1 00 00 00 00 00 00 00 00 00 00 01")]
    public class _Cwk_2_Fingerprint : IFileTypeFingerprint { }
}