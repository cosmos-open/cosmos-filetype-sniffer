using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("aar")]
[FileTypeHex("50,4b,03,04")]
[FileTypeDescription("Android Archive file")]
public class _Aar_1_Fingerprint : IFileTypeFingerprint { }
    
[FileTypeExtensionNames("aar")]
[FileTypeHex("50,4b,07,08")]
[FileTypeDescription("Android Archive file")]
public class _Aar_2_Fingerprint : IFileTypeFingerprint { }
    
[FileTypeExtensionNames("aar")]
[FileTypeHex("50,4b,05,06")]
[FileTypeDescription("Android Archive file")]
public class _Aar_3_Fingerprint : IFileTypeFingerprint { }