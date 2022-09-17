using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("docx")]
[FileTypeHex("50,4b,03,04")]
[FileTypeDescription("Microsoft Office Word OOXML file")]
public class _Docx_1_Fingerprint : IFileTypeFingerprint { }
    
[FileTypeExtensionNames("docx")]
[FileTypeHex("50,4b,07,08")]
[FileTypeDescription("Microsoft Office Word OOXML file")]
public class _Docx_2_Fingerprint : IFileTypeFingerprint { }
    
[FileTypeExtensionNames("docx")]
[FileTypeHex("50,4b,05,06")]
[FileTypeDescription("Microsoft Office Word OOXML file")]
public class _Docx_3_Fingerprint : IFileTypeFingerprint { }