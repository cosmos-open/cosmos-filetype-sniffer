using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("wasm")]
    [FileTypeHex("00 61 73 6d")]
    public class _Wasm_Fingerprint : IFileTypeFingerprint { }
}