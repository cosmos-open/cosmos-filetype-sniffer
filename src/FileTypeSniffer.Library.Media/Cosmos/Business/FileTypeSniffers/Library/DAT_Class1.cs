﻿using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("dat")]
    [FileTypeHex("50 4D 4F 43 43 4D 4F 43")]
    public class DAT_Class1 : IFileTypeRegistrar { }
}