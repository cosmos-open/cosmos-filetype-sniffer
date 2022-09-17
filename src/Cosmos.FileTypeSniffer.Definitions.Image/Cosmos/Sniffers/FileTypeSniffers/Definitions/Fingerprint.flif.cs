using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("flif")]
[FileTypeHex("46 4C 49 46")]
public class _Flif_Fingerprint : IFileTypeFingerprint { }