using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("rpm")]
[FileTypeHex("ed ab ee db")]
public class _Rpm_Fingerprint : IFileTypeFingerprint { }