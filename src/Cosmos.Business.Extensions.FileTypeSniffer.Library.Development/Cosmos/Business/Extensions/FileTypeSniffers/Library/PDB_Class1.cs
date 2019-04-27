using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("pdb")]
    [FileTypeHex("00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00")]
    [FileTypeOffset(11)]
    [FileTypeDescription("Program Database File")]
    public class PDB_Class1 : IFileTypeRegistrar { }
}