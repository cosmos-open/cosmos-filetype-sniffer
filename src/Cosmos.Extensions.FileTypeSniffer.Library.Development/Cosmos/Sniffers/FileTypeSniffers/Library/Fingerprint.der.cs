using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("der")]
    [FileTypeHex("30 82")]
    public class _Der_Fingerprint : IFileTypeFingerprint { }
}