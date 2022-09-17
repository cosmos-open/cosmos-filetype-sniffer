using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("jpg,jpeg")]
[FileTypeHex("FF D8 FF E0 ?? ?? 4A 46 49 46 00 01")]
public class _Jpg_1_Fingerprint : IFileTypeFingerprint { }
    
[FileTypeExtensionNames("jpg,jpeg")]
[FileTypeHex("FF D8 FF E1 ?? ?? 45 78 69 66 00 00")]
public class _Jpg_2_Fingerprint : IFileTypeFingerprint { }
    
[FileTypeExtensionNames("jpg,jpeg")]
[FileTypeHex("ff,d8,ff,db")]
public class _Jpg_3_Fingerprint : IFileTypeFingerprint { }