using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("gz,tar.gz")]
[FileTypeHex("1F 8B")]
public class _Gz_Fingerprint : IFileTypeFingerprint { }