using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("rar")]
[FileTypeHex("52,61,72,21,1a,07,00")]
public class _Rar_1_Fingerprint : IFileTypeFingerprint { }

[FileTypeExtensionNames("rar")]
[FileTypeHex("52,61,72,21,1a,07,01,00")]
public class _Rar_2_Fingerprint : IFileTypeFingerprint { }