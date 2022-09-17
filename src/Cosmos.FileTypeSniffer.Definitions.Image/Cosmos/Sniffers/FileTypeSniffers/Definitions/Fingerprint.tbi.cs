using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("tbi")]
[FileTypeHex("00 00 00 00 14 00 00 00")]
public class _Tbi_Fingerprint : IFileTypeFingerprint { }