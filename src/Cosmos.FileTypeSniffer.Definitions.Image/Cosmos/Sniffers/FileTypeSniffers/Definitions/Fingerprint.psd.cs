using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("psd")]
[FileTypeHex("38 42 50 53")]
public class _Psd_Fingerprint : IFileTypeFingerprint { }