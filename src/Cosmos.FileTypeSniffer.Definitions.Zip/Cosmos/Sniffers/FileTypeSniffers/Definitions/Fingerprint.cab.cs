using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("cab")]
[FileTypeHex("4D 53 43 46")]
public class _Cab_Fingerprint : IFileTypeFingerprint { }