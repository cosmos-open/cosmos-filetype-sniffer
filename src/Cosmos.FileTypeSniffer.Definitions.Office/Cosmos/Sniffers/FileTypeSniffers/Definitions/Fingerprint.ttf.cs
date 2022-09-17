using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("ttf")]
[FileTypeHex("00 01 00 00 00")]
public class _Ttf_Fingerprint : IFileTypeFingerprint { }