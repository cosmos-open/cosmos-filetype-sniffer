using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("emmx")]
    [FileTypeHex("50 4B 03 14 00 00 00 08")]
    [FileTypeDescription("EDraw MindMaster")]
    public class _Emmx_Fingerprint : IFileTypeFingerprint { }
}