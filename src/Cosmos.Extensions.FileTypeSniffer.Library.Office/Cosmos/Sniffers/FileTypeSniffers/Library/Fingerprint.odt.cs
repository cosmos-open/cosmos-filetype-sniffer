using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("odt")]
    [FileTypeHex("50,4b,03,04")]
    [FileTypeDescription("OpenDocument Text")]
    public class _Odt_1_Fingerprint : IFileTypeFingerprint { }

    [FileTypeExtensionNames("odt")]
    [FileTypeHex("50,4b,07,08")]
    [FileTypeDescription("OpenDocument Text")]
    public class _Odt_2_Fingerprint : IFileTypeFingerprint { }

    [FileTypeExtensionNames("odt")]
    [FileTypeHex("50,4b,05,06")]
    [FileTypeDescription("OpenDocument Text")]
    public class _Odt_3_Fingerprint : IFileTypeFingerprint { }
}