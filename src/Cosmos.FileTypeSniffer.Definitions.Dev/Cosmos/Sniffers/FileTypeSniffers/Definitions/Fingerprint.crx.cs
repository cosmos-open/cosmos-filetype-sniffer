using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("crx")]
[FileTypeHex("43 72 32 34")]
[FileTypeDescription("Google Chrome extensions file")]
public class _Crx_Fingerprint : IFileTypeFingerprint { }