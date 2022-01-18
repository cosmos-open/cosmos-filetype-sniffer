using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("gif")]
    [FileTypeHex("47 49 46 38 37 61")]
    public class _Gif_1_Fingerprint : IFileTypeFingerprint { }
    
    [FileTypeExtensionNames("gif")]
    [FileTypeHex("47 49 46 38 39 61")]
    public class _Gif_2_Fingerprint : IFileTypeFingerprint { }
}