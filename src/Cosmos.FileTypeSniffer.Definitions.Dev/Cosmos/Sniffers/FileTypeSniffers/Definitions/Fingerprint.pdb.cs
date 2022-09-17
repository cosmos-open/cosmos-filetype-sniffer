using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("pdb")]
[FileTypeHex("00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00")]
[FileTypeOffset(11)]
[FileTypeDescription("Program Database File")]
public class _Pdb_Fingerprint : IFileTypeFingerprint { }