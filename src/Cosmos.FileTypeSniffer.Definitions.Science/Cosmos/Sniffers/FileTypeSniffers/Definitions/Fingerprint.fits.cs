using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("fits")]
[FileTypeHex("3D 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 54")]
[FileTypeDescription("Flexible Image Transport System")]
public class _Fits_Fingerprint : IFileTypeFingerprint { }