using Cosmos.Sniffers.FileTypeSniffers.Core;

namespace Cosmos.Sniffers.FileTypeSniffers;

/// <summary>
/// Expected file type sniffer <br />
/// 具有期待结果的文件类型嗅探器
/// </summary>
public class ExpectedFileTypeSniffer : IFileTypeSniffer
{
    private readonly IFileTypeSniffer _innerSniffer;
    private readonly List<string> _expectedResults;
    private readonly int _expectedCount;
    private readonly bool _singleMode;

    public ExpectedFileTypeSniffer(IFileTypeSniffer instance, List<string> expectedResults) : this(instance, expectedResults, false) { }

    public ExpectedFileTypeSniffer(IFileTypeSniffer instance, string expectedResult) : this(instance, new List<string> { expectedResult }, true) { }

    private ExpectedFileTypeSniffer(IFileTypeSniffer instance, List<string> expectedResults, bool singleMode)
    {
        _innerSniffer = instance ?? throw new ArgumentNullException(nameof(instance));
        _expectedResults = FixedExpectedResults(expectedResults ?? throw new ArgumentNullException(nameof(expectedResults))).ToList();
        _expectedCount = expectedResults.Count;
        _singleMode = singleMode;
    }

    /// <inheritdoc />
    public List<string> Match(byte[] data, bool matchAll = false)
    {
        var rawResults = _innerSniffer.Match(data, matchAll);

        return _expectedCount == 0
            ? rawResults
            : Filter(rawResults, _expectedResults).ToList();
    }

    /// <inheritdoc />
    public List<string> Match(string filePath, int simpleLength, bool matchAll = false)
    {
        var rawResults = _innerSniffer.Match(filePath, simpleLength, matchAll);

        return _expectedCount == 0
            ? rawResults
            : Filter(rawResults, _expectedResults).ToList();
    }

    /// <inheritdoc />
    public string MatchSingle(byte[] data)
    {
        var rawResults = _innerSniffer.Match(data, true);

        if (_singleMode)
        {
            return rawResults.Any()
                ? SingleFilter(rawResults, _expectedResults)
                : string.Empty;
        }
        else
        {
            return _expectedCount == 0
                ? rawResults.FirstOrDefault()
                : Filter(rawResults, _expectedResults).FirstOrDefault();
        }
    }

    /// <inheritdoc />
    public string MatchSingle(string filePath, int simpleLength)
    {
        var rawResults = _innerSniffer.Match(filePath, simpleLength, true);

        if (_singleMode)
        {
            return rawResults.Any()
                ? SingleFilter(rawResults, _expectedResults)
                : string.Empty;
        }
        else
        {
            return _expectedCount == 0
                ? rawResults.FirstOrDefault()
                : Filter(rawResults, _expectedResults).FirstOrDefault();
        }
    }

    private static IEnumerable<string> Filter(List<string> rawResults, List<string> expectedResults)
    {
        foreach (var result in rawResults)
        {
            if (expectedResults.Contains(result))
                yield return result;
        }
    }

    private static string SingleFilter(List<string> rawResults, List<string> expectedResults)
    {
        var expectedResult = expectedResults.Single();
        foreach (var result in rawResults)
        {
            if (string.Compare(result, expectedResult, StringComparison.OrdinalIgnoreCase) == 0)
                return expectedResult;
        }

        return string.Empty;
    }

    private static IEnumerable<string> FixedExpectedResults(List<string> originalExpectedResults)
    {
        if (originalExpectedResults == null)
            throw new ArgumentNullException(nameof(originalExpectedResults));

        foreach (var result in originalExpectedResults)
        {
            if (string.IsNullOrWhiteSpace(result))
                continue;
            yield return result.RemoveDotAtFirstPosition().ToLower();
        }
    }

    /// <inheritdoc />
    public IFileTypeSniffer Expect(List<string> expectedResults) => new ExpectedFileTypeSniffer(_innerSniffer, expectedResults);

    /// <inheritdoc />
    public IFileTypeSniffer Expect(string expectedResult) => new ExpectedFileTypeSniffer(_innerSniffer, expectedResult);

    /// <inheritdoc />
    public SniffingReadOnlyMetadataStatistics GetMetadataStatistics() => _innerSniffer.GetMetadataStatistics();
}