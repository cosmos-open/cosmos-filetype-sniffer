using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("mp3")]
[FileTypeHex("FF FB")]
public class _Mp3_1_Fingerprint : IFileTypeFingerprint { }
    
[FileTypeExtensionNames("mp3")]
[FileTypeHex("49 44 33")]
public class _Mp3_2_Fingerprint : IFileTypeFingerprint { }