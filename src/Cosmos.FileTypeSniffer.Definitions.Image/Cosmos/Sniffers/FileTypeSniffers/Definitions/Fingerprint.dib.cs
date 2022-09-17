using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("dib")]
[FileTypeHex("42 4D")]
public class _Dib_Fingerprint : IFileTypeFingerprint { }