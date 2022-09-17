using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("nes")]
[FileTypeHex("4E 45 53 1A")]
public class _Nes_Fingerprint : IFileTypeFingerprint { }