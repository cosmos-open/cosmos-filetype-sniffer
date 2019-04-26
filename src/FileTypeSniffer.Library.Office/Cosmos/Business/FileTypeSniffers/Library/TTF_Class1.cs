﻿using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("ttf")]
    [FileTypeHex("00 01 00 00 00")]
    public class TTF_Class1 : IFileTypeRegistrar { }
}