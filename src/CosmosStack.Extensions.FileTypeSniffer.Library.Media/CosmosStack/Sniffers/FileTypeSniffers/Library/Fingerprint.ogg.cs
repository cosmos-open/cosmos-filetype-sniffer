using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("ogg oga ogv")]
    [FileTypeHex("30 26 B2 75 8E 66 CF 11 A6 D9 00 AA 00 62 CE 6C")]
    public class _Ogg_Fingerprint : IFileTypeFingerprint { }
}