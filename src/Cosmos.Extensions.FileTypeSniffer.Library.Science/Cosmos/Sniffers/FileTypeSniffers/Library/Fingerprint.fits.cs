using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("fits")]
    [FileTypeHex("3D 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 54")]
    [FileTypeDescription("Flexible Image Transport System")]
    public class _Fits_Fingerprint : IFileTypeFingerprint { }
}