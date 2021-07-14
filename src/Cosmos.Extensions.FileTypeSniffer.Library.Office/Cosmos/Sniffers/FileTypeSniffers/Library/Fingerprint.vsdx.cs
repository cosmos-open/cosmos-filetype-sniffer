using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("vsdx")]
    [FileTypeHex("50,4b,03,04")]
    [FileTypeDescription("Microsoft Office Visio file")]
    public class _Vsdx_1_Fingerprint : IFileTypeFingerprint { }

    [FileTypeExtensionNames("vsdx")]
    [FileTypeHex("50,4b,07,08")]
    [FileTypeDescription("Microsoft Office Visio file")]
    public class _Vsdx_2_Fingerprint : IFileTypeFingerprint { }

    [FileTypeExtensionNames("vsdx")]
    [FileTypeHex("50,4b,05,06")]
    [FileTypeDescription("Microsoft Office Visio file")]
    public class _Vsdx_3_Fingerprint : IFileTypeFingerprint { }
}