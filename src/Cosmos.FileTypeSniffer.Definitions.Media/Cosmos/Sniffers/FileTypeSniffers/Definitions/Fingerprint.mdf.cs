using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("mdf")]
[FileTypeHex("00 FF FF FF FF FF FF FF FF FF FF 00 00 02 00 01")]
public class _Mdf_Fingerprint : IFileTypeFingerprint { }