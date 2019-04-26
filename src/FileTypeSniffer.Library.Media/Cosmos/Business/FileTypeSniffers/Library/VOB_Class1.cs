﻿using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("vob")]
    [FileTypeHex("00 00 01 BA")]
    public class VOB_Class1 : IFileTypeRegistrar { }
}