using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("wasm")]
[FileTypeHex("00 61 73 6d")]
public class _Wasm_Fingerprint : IFileTypeFingerprint { }