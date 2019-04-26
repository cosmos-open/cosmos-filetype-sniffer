﻿using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("zlib")]
    [FileTypeHex("78 01")]
    public class ZLIB_Class1 : IFileTypeRegistrar { }
}