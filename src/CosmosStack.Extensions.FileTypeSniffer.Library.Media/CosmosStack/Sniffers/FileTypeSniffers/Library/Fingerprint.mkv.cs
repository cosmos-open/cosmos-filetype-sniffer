using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("mkv mka mks mk3d")]
    [FileTypeHex("1A 45 DF A3")]
    public class _Mkv_Fingerprint : IFileTypeFingerprint { }
}