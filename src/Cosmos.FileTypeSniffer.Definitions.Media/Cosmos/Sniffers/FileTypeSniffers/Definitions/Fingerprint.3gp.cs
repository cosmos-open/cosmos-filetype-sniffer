using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("3gp")]
[FileTypeHex("66 74 79 70 33 67")]
[FileTypeOffset(4)]
public class _3gp_Fingerprint : IFileTypeFingerprint { }