using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("ico")]
[FileTypeHex("00 00 01 00")]
public class _Ico_Fingerprint : IFileTypeFingerprint { }