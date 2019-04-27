using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("wasm")]
    [FileTypeHex("00 61 73 6d")]
    public class WASM_Class1 : IFileTypeRegistrar { }
}