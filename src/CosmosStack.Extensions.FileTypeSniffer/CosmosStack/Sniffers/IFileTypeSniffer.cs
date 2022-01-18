using System.Collections.Generic;
using CosmosStack.Sniffers.FileTypeSniffers.Core;

namespace CosmosStack.Sniffers
{
    /// <summary>
    /// FileType Sniffer Interface <br />
    /// 文件类型嗅探器接口
    /// </summary>
    public interface IFileTypeSniffer
    {
        /// <summary>
        /// Match <br />
        /// 获取匹配的文件扩展名
        /// </summary>
        /// <param name="data"></param>
        /// <param name="matchAll"></param>
        /// <returns></returns>
        List<string> Match(byte[] data, bool matchAll = false);

        /// <summary>
        /// Match <br />
        /// 获取匹配的文件扩展名
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="simpleLength"></param>
        /// <param name="matchAll"></param>
        /// <returns></returns>
        List<string> Match(string filePath, int simpleLength, bool matchAll = false);

        /// <summary>
        /// Match Single <br />
        /// 获取单个匹配的文件扩展名
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        string MatchSingle(byte[] data);

        /// <summary>
        /// Match Single <br />
        /// 获取单个匹配的文件扩展名
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="simpleLength"></param>
        /// <returns></returns>
        string MatchSingle(string filePath, int simpleLength);

        /// <summary>
        /// Expect <br />
        /// 期待
        /// </summary>
        /// <param name="expectedResults"></param>
        /// <returns></returns>
        IFileTypeSniffer Expect(List<string> expectedResults);

        /// <summary>
        /// Expect <br />
        /// 期待
        /// </summary>
        /// <param name="expectedResult"></param>
        /// <returns></returns>
        IFileTypeSniffer Expect(string expectedResult);

        /// <summary>
        /// Get Metadata Statistics <br />
        /// 获取元数据统计信息
        /// </summary>
        /// <returns></returns>
        SniffingReadOnlyMetadataStatistics GetMetadataStatistics();
    }
}