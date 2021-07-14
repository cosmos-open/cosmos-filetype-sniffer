using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("xml")]
    [FileTypeHex("3c 3f 78 6d 6c 20")]
    public class _Xml_Fingerprint : IFileTypeFingerprint { }
}