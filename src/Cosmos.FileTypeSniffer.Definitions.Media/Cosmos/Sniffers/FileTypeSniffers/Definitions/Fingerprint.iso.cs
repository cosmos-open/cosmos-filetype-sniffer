using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("iso")]
[FileTypeHex("43 44 30 30 31")]
[FileTypeOffset(32769)]
public class _Iso_1_Fingerprint : IFileTypeFingerprint { }

[FileTypeExtensionNames("iso")]
[FileTypeHex("43 44 30 30 31")]
[FileTypeOffset(34817)]
public class _Iso_2_Fingerprint : IFileTypeFingerprint { }

[FileTypeExtensionNames("iso")]
[FileTypeHex("43 44 30 30 31")]
[FileTypeOffset(36865)]
public class _Iso_3_Fingerprint : IFileTypeFingerprint { }