using CosmosStack.Sniffers.FileTypeSniffers.Registering;

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("rc")]
    [FileTypeHex("53 45 51 36")]
    public class _Rc_Fingerprint : IFileTypeFingerprint { }
}