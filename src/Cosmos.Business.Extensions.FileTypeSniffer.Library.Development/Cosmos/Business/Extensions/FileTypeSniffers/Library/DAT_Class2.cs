using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("dat")]
    [FileTypeHex("00 00 00 00 62 31 05 00 09 00 00 00 00 20 00 00 00 09 00 00 00 00 00 00")]
    [FileTypeOffset(8)]
    [FileTypeDescription("Bitcoin Core wallet.dat file")]
    public class DAT_Class2 : IFileTypeRegistrar { }
}