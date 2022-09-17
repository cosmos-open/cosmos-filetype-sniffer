using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("mkv mka mks mk3d")]
[FileTypeHex("1A 45 DF A3")]
public class _Mkv_Fingerprint : IFileTypeFingerprint { }