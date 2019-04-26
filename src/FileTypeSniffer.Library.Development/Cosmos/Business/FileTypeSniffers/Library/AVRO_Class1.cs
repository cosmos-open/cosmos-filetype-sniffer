using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("avro")]
    [FileTypeHex("4F 62 6A 01")]
    [FileTypeDescription("Apache Avro file")]
    public class AVRO_Class1 : IFileTypeRegistrar { }
}