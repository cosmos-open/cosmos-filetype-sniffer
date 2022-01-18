using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("jp2")]
    [FileTypeHex("00 00 00 0C 6A 50 20 20 0D 0A")]
    [FileTypeDescription("Various JPEG-2000 image file formats")]
    public class _Jp2_Fingerprint : IFileTypeFingerprint { }
}