using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CosmosStack.Sniffers;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

// ReSharper disable once CheckNamespace
namespace IntegrationTests
{
    public class ExpectedTest
    {
        private IFileTypeSniffer Sniffer { get; set; }
        private string Local { get; set; }

        public ExpectedTest()
        {
            var services = new ServiceCollection();
            services.AddCosmosFileTypeSniffer();
            var provider = services.BuildServiceProvider();

            Sniffer = provider.GetRequiredService<IFileTypeSniffer>();
            Local = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "samples");
        }

        [Fact]
        public void WordDoc()
        {
            var bytes = LoadBytes("sniffer.doc", 20);
            var results = Sniffer.Expect(new List<string>() { "doc" }).Match(bytes, true);
            var one = results.FirstOrDefault();
            var count = results.Count;
            Assert.Contains("doc", results);
            Assert.Equal(1, count);
            Assert.Equal("doc", one);
        }

        [Fact]
        public void WordDoc_Single()
        {
            var bytes = LoadBytes("sniffer.doc", 20);
            var results = Sniffer.Expect("doc").Match(bytes, true);
            var result1 = Sniffer.Expect("doc").MatchSingle(bytes);
            var one = results.FirstOrDefault();
            var count = results.Count;
            Assert.Contains("doc", results);
            Assert.Equal(1, count);
            Assert.Equal("doc", one);
            Assert.Equal("doc", result1);
        }


        [Fact]
        public void WordDocx()
        {
            var bytes = LoadBytes("sniffer.docx", 20);
            var results = Sniffer.Expect(new List<string>() { "docx" }).Match(bytes, true);
            var one = results.FirstOrDefault();
            var count = results.Count;
            Assert.Contains("docx", results);
            Assert.Equal(1, count);
            Assert.Equal("docx", one);
        }

        [Fact]
        public void WordDocx_Doc()
        {
            var bytes = LoadBytes("sniffer.docx", 20);
            var results = Sniffer.Expect(new List<string>() { "docx", "doc" }).Match(bytes, true);
            var one = results.FirstOrDefault();
            var count = results.Count;
            Assert.Contains("docx", results);
            Assert.Equal(1, count);
            Assert.Equal("docx", one);
        }

        [Fact]
        public void WordDocx_Xlsx()
        {
            var bytes = LoadBytes("sniffer.docx", 20);
            var results = Sniffer.Expect(new List<string>() { "docx", "xlsx" }).Match(bytes, true);
            var one = results.FirstOrDefault(x => x == "docx");
            var count = results.Count;
            Assert.Contains("docx", results);
            Assert.Equal(2, count);
            Assert.Equal("docx", one);
        }

        private byte[] LoadBytes(string fileName, int length)
        {
            var path = Path.Combine(Local, fileName);
            byte[] array = new byte[length];
            using (var file = File.Open(path, FileMode.Open))
            {
                file.Read(array, 0, array.Length);
            }

            return array;
        }
    }
}
