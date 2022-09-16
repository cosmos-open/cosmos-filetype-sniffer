namespace Cosmos.Sniffers.FileTypeSniffers.Core;

internal static class SniffingMetadataExtensions
{
    public static List<string> Match(this List<SniffingMetadata> sniffingList, byte[] data, bool matchAll = false)
    {
        var ret = new List<string>();

        foreach (var metadata in sniffingList)
        {
            if (metadata.IsMatched(data))
            {
                ret.AddRange(metadata.ExtensionNames);
                if (!matchAll) break;
            }
        }

        return ret;
    }
}