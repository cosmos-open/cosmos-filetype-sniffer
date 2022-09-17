using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("tar")]
[FileTypeHex("75 73 74 61 72")]
[FileTypeOffset(257)]
public class _Tar_Fingerprint : IFileTypeFingerprint { }