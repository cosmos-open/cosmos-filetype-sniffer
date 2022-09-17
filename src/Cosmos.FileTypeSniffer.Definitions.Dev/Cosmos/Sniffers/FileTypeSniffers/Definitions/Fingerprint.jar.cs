using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("jar")]
[FileTypeHex("50,4b,03,04")]
public class _Jar_1_Fingerprint : IFileTypeFingerprint { }
    
[FileTypeExtensionNames("jar")]
[FileTypeHex("50,4b,07,08")]
public class _Jar_2_Fingerprint : IFileTypeFingerprint { }
    
[FileTypeExtensionNames("jar")]
[FileTypeHex("50,4b,05,06")]
public class _Jar_3_Fingerprint : IFileTypeFingerprint { }