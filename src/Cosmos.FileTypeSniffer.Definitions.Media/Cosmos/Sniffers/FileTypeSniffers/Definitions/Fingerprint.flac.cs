using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("flac")]
[FileTypeHex("66 4C 61 43")]
public class _Flac_Fingerprint : IFileTypeFingerprint { }