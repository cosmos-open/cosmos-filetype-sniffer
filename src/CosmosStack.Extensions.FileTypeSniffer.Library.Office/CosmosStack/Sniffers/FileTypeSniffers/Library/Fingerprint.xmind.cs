using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("xmind")]
    [FileTypeHex("50,4b,03,04,14")]
    [FileTypeDescription("XMind (8)")]
    public class _Xmind_1_Fingerprint : IFileTypeFingerprint { }
    
    [FileTypeExtensionNames("xmind")]
    [FileTypeHex("50,4b,03,04,0a")]
    [FileTypeDescription("XMind (Zen)")]
    public class _Xmind_2_Fingerprint : IFileTypeFingerprint { }
}