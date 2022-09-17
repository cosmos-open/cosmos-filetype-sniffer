using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("ppt")]
[FileTypeHex("D0 CF 11 E0 A1 B1 1A E1")]
[FileTypeDescription("Microsoft Office PowerPoint file")]
public class _Ppt_Fingerprint : IFileTypeFingerprint { }