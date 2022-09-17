using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("pdf")]
[FileTypeHex("25 50 44 46")]
public class _Pdf_Fingerprint : IFileTypeFingerprint { }