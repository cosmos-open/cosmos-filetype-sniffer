using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("dps")]
    [FileTypeHex("d0,cf,11,e0,a1,b1,1a,e1")]
    [FileTypeDescription("Kingsoft WPS Office DPS file")]
    public class _Dps_Fingerprint : IFileTypeFingerprint { }
}