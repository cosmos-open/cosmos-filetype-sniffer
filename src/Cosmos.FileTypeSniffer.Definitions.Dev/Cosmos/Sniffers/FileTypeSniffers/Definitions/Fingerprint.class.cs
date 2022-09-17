using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("class")]
[FileTypeHex("CA FE BA BE")]
public class _Class_Fingerprint : IFileTypeFingerprint { }