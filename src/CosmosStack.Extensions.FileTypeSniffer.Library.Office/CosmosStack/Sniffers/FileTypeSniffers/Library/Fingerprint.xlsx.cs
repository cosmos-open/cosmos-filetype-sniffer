using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("xlsx")]
    [FileTypeHex("50,4b,03,04")]
    [FileTypeDescription("Microsoft Office Excel OOXML file")]
    public class _Xlsx_1_Fingerprint : IFileTypeFingerprint { }
    
    [FileTypeExtensionNames("xlsx")]
    [FileTypeHex("50,4b,07,08")]
    [FileTypeDescription("Microsoft Office Excel OOXML file")]
    public class _Xlsx_2_Fingerprint : IFileTypeFingerprint { }
    
    [FileTypeExtensionNames("xlsx")]
    [FileTypeHex("50,4b,05,06")]
    [FileTypeDescription("Microsoft Office Excel OOXML file")]
    public class _Xlsx_3_Fingerprint : IFileTypeFingerprint { }
}