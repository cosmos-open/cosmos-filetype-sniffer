using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("vob")]
[FileTypeHex("00 00 01 BA")]
public class _Vob_Fingerprint : IFileTypeFingerprint { }