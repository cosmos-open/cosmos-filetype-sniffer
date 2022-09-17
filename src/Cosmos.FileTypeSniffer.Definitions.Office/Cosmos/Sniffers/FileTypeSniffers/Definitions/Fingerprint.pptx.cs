using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("pptx")]
[FileTypeHex("50,4b,03,04")]
[FileTypeDescription("Microsoft Office PowerPoint OOXML file")]
public class _Pptx_1_Fingerprint : IFileTypeFingerprint { }
    
[FileTypeExtensionNames("pptx")]
[FileTypeHex("50,4b,07,08")]
[FileTypeDescription("Microsoft Office PowerPoint OOXML file")]
public class _Pptx_2_Fingerprint : IFileTypeFingerprint { }
    
[FileTypeExtensionNames("pptx")]
[FileTypeHex("50,4b,05,06")]
[FileTypeDescription("Microsoft Office PowerPoint OOXML file")]
public class _Pptx_3_Fingerprint : IFileTypeFingerprint { }