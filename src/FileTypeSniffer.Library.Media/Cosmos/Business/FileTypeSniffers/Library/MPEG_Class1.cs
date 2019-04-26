﻿using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("mpg mpeg")]
    [FileTypeHex("00 00 01 B3")]
    public class MPEG_Class1 : IFileTypeRegistrar { }
}
