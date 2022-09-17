using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("dpx")]
[FileTypeHex("53 44 50 58")]
public class _Dpx_1_Fingerprint : IFileTypeFingerprint { }
    
[FileTypeExtensionNames("dpx")]
[FileTypeHex("58 50 44 53")]
public class _Dpx_2_Fingerprint : IFileTypeFingerprint { }