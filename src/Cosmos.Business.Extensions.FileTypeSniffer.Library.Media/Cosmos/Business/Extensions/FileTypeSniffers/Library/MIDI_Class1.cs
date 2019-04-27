using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("mid,midi")]
    [FileTypeHex("4D 54 68 64")]
    public class MIDI_Class1 : IFileTypeRegistrar { }
}