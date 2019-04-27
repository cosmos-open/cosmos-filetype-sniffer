using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("avro")]
    [FileTypeHex("4F 62 6A 01")]
    [FileTypeDescription("Apache Avro file")]
    public class AVRO_Class1 : IFileTypeRegistrar { }
}