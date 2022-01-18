using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("z,tar.z")]
    [FileTypeHex("1F 9D")]
    public class _Z_1_Fingerprint : IFileTypeFingerprint { }
    
    [FileTypeExtensionNames("z,tar.z")]
    [FileTypeHex("1F A0")]
    public class _Z_2_Fingerprint : IFileTypeFingerprint { }
}