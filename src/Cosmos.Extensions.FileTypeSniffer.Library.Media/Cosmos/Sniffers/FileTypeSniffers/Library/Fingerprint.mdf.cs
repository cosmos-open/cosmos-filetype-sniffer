using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("mdf")]
    [FileTypeHex("00 FF FF FF FF FF FF FF FF FF FF 00 00 02 00 01")]
    public class _Mdf_Fingerprint : IFileTypeFingerprint { }
}