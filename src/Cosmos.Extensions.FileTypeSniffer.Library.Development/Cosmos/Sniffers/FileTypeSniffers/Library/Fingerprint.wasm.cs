using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("wasm")]
    [FileTypeHex("00 61 73 6d")]
    public class _Wasm_Fingerprint : IFileTypeFingerprint { }
}