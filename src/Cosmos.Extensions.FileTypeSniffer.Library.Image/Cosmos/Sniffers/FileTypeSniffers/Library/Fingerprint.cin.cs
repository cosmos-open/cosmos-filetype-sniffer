using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("cin")]
    [FileTypeHex("80 2A 5F D7")]
    [FileTypeDescription("柯达 Kodak Cineon 影像系统图像文件格式")]
    public class _Cin_Fingerprint : IFileTypeFingerprint { }
}