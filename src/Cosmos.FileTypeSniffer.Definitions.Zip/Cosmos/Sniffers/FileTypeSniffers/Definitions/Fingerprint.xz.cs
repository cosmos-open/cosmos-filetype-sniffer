using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("xz,tar.xz")]
[FileTypeHex("FD 37 7A 58 5A 00 00")]
public class _Xz_Fingerprint : IFileTypeFingerprint { }