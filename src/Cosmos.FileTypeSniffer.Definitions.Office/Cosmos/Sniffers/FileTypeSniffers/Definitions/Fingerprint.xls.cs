using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("xls")]
[FileTypeHex("D0 CF 11 E0 A1 B1 1A E1")]
[FileTypeDescription("Microsoft Office Excel file")]
public class _Xls_Fingerprint : IFileTypeFingerprint { }