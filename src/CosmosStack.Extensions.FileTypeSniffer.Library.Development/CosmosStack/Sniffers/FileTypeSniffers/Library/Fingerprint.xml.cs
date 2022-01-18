using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("xml")]
    [FileTypeHex("3c 3f 78 6d 6c 20")]
    public class _Xml_Fingerprint : IFileTypeFingerprint { }
}