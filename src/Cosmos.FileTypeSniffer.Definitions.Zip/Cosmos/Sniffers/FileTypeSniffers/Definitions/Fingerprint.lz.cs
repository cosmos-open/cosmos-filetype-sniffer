using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("lz")]
[FileTypeHex("4C 5A 49 50")]
[FileTypeDescription("Lzip Compressed File")]
public class _Lz_Fingerprint : IFileTypeFingerprint { }