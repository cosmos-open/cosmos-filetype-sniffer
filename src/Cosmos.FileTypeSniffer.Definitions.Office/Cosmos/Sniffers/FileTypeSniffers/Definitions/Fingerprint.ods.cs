using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("ods")]
[FileTypeHex("50,4b,03,04")]
[FileTypeDescription("OpenDocument Sheet")]
public class _Ods_1_Fingerprint : IFileTypeFingerprint { }

[FileTypeExtensionNames("ods")]
[FileTypeHex("50,4b,07,08")]
[FileTypeDescription("OpenDocument Sheet")]
public class _Ods_2_Fingerprint : IFileTypeFingerprint { }

[FileTypeExtensionNames("ods")]
[FileTypeHex("50,4b,05,06")]
[FileTypeDescription("OpenDocument Sheet")]
public class _Ods_3_Fingerprint : IFileTypeFingerprint { }