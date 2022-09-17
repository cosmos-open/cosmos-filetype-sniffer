using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("der")]
[FileTypeHex("30 82")]
public class _Der_Fingerprint : IFileTypeFingerprint { }