using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("mpg mpeg")]
[FileTypeHex("00 00 01 B3")]
public class _Mpeg_1_Fingerprint : IFileTypeFingerprint { }
    
[FileTypeExtensionNames("mpg mpeg")]
[FileTypeHex("00 00 01 BA")]
public class _Mpeg_2_Fingerprint : IFileTypeFingerprint { }