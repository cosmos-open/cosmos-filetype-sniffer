using Cosmos.Reflection;
using Cosmos.Sniffers.FileTypeSniffers.Core;

namespace Cosmos.Sniffers.FileTypeSniffers.Registering;

/// <summary>
/// File Type Descriptor <br />
/// 文件类型描述符
/// </summary>
public class FileTypeDescriptor : IFileTypeDescriptor
{
    public FileTypeDescriptor(Type registrarType)
    {
        CheckType(registrarType);

        Description = GetDescription(registrarType);
        ExtensionNames = GetExtensionNames(registrarType);
        Hex = GetHex(registrarType);
        Offset = GetOffset(registrarType);
    }

    /// <inheritdoc />
    public string Description { get; }

    /// <inheritdoc />
    public string ExtensionNames { get; }

    /// <inheritdoc />
    public List<string> ResolveExtensionNames(char[] separators)
    {
        if (string.IsNullOrWhiteSpace(ExtensionNames.Trim()))
            return Enumerable.Empty<string>().ToList();
        if (separators is null || !separators.Any())
            separators = new[] { ',', ' ' };
        return ExtensionNames.Split(separators).ToList();
    }

    /// <inheritdoc />
    public string Hex { get; }

    /// <inheritdoc />
    public int Offset { get; }

    /// <inheritdoc />
    public string[] ResolveHex(string source, char[] separators)
    {
        var hex = Offset > 0
            ? $"{source.Repeat(Offset, ',')}{Hex}"
            : Hex;

        return hex.Split(separators);
    }

    /// <inheritdoc />
    public bool IsComplexMetadata => (Offset > 0) || (Hex.Contains("?"));

    private void CheckType(Type type)
    {
        if (type is null)
            throw new ArgumentNullException(nameof(type));

        if (!typeof(IFileTypeFingerprint).IsAssignableFrom(type))
            throw new ArgumentException($"Type {type} cannot be assignable from {typeof(IFileTypeFingerprint)}", nameof(type));
    }

    private string GetDescription(Type type)
    {
        var descAttr = type.GetReflector().GetAttribute<FileTypeDescriptionAttribute>();
        return descAttr?.Description ?? string.Empty;
    }

    private string GetExtensionNames(Type type)
    {
        var extNameAttr = type.GetReflector().GetAttribute<FileTypeExtensionNamesAttribute>();
        return extNameAttr?.ExtensionNames ?? string.Empty;
    }

    private string GetHex(Type type)
    {
        var hexAttr = type.GetReflector().GetAttribute<FileTypeHexAttribute>();
        return hexAttr?.Hex ?? string.Empty;
    }

    private int GetOffset(Type type)
    {
        var offsetAttr = type.GetReflector().GetAttribute<FileTypeOffsetAttribute>();
        return offsetAttr?.Offset ?? 0;
    }
}