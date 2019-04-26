﻿using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("stg")]
    [FileTypeHex("4D 49 4C 20")]
    public class STG_Class1 : IFileTypeRegistrar { }
}