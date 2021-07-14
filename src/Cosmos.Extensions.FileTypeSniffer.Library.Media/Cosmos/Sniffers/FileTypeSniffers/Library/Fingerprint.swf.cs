using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("swf")]
    [FileTypeHex("43 57 53")]
    public class _Swf_1_Fingerprint : IFileTypeFingerprint { }
    
    [FileTypeExtensionNames("swf")]
    [FileTypeHex("46 57 53")]
    public class _Swf_2_Fingerprint : IFileTypeFingerprint { }
}
