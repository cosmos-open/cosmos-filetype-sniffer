using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("ps")]
[FileTypeHex("25 21 50 53")]
public class _Ps_Fingerprint : IFileTypeFingerprint { }