using System;
using System.IO;
using System.Linq;
using Cosmos.Business.Extensions.FileTypeSniffers;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace IntegrationTests
{
    public class UnitTest1
    {
        private IFileTypeSniffer Sniffer { get; set; }
        private string Local { get; set; }

        public UnitTest1()
        {
            var services = new ServiceCollection();
            services.AddFileTypeSniffer();
            var provider = services.BuildServiceProvider();

            Sniffer = provider.GetRequiredService<IFileTypeSniffer>();
            Local = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "samples");
        }

        [Fact]
        public void WordDoc()
        {
            var bytes = LoadBytes("sniffer.doc", 20);
            var results = Sniffer.Match(bytes, true);
            Assert.Contains("doc", results);
        }

        [Fact]
        public void WordDocx()
        {
            var bytes = LoadBytes("sniffer.docx", 20);
            var results = Sniffer.Match(bytes, true);
            Assert.Contains("docx", results);
        }

        [Fact]
        public void ExcelXls()
        {
            var bytes = LoadBytes("sniffer.xls", 20);
            var results = Sniffer.Match(bytes, true);
            Assert.Contains("xls", results);
        }

        [Fact]
        public void ExcelXlsx()
        {
            var bytes = LoadBytes("sniffer.xlsx", 20);
            var results = Sniffer.Match(bytes, true);
            Assert.Contains("xlsx", results);
        }

        [Fact]
        public void PowerPointPpt()
        {
            var bytes = LoadBytes("sniffer.ppt", 20);
            var results = Sniffer.Match(bytes, true);
            Assert.Contains("ppt", results);
        }

        [Fact]
        public void PowerPointPptx()
        {
            var bytes = LoadBytes("sniffer.pptx", 20);
            var results = Sniffer.Match(bytes, true);
            Assert.Contains("pptx", results);
        }

        [Fact]
        public void Zip()
        {
            var bytes = LoadBytes("sniffer.zip", 20);
            var results = Sniffer.Match(bytes, true);
            Assert.Contains("zip", results);
        }

        [Fact]
        public void Zip7z()
        {
            var bytes = LoadBytes("sniffer.7z", 20);
            var results = Sniffer.Match(bytes, true);
            Assert.Contains("7z", results);
        }

        [Fact]
        public void Tiff()
        {
            var bytes = LoadBytes("sniffer.tiff", 20);
            var results = Sniffer.Match(bytes, true);
            Assert.Contains("tiff", results);
        }

        [Fact]
        public void Rtf()
        {
            var bytes = LoadBytes("sniffer.rtf", 20);
            var results = Sniffer.Match(bytes, true);
            Assert.Contains("rtf", results);
        }

        [Fact]
        public void Ps()
        {
            var bytes = LoadBytes("sniffer.ps", 20);
            var results = Sniffer.Match(bytes, true);
            Assert.Contains("ps", results);
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
