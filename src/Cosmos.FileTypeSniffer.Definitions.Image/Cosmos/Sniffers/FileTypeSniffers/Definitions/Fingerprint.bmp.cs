using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("bmp")]
[FileTypeHex("42 4D")]
public class _Bmp_Fingerprint : IFileTypeFingerprint { }