using System;
using System.IO;
using Cosmos.Business.Extensions.FileTypeSniffers;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace IntegrationTests
{
    public class FilePathTest
    {
        private IFileTypeSniffer Sniffer { get; set; }
        private string Local { get; set; }

        public FilePathTest()
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
            var path = Path.Combine(Local, "sniffer.doc");
            var results = Sniffer.Match(path, 20, true);
            Assert.Contains("doc", results);
        }
        
         [Fact]
        public void WordDocx()
        {
            var path = Path.Combine(Local, "sniffer.docx");
            var results = Sniffer.Match(path, 20, true);
            Assert.Contains("docx", results);
        }

        [Fact]
        public void ExcelXls()
        {
            var path = Path.Combine(Local, "sniffer.xls");
            var results = Sniffer.Match(path, 20, true);
            Assert.Contains("xls", results);
        }

        [Fact]
        public void ExcelXlsx()
        {
            var path = Path.Combine(Local, "sniffer.xlsx");
            var results = Sniffer.Match(path, 20, true);
            Assert.Contains("xlsx", results);
        }

        [Fact]
        public void PowerPointPpt()
        {
            var path = Path.Combine(Local, "sniffer.ppt");
            var results = Sniffer.Match(path, 20, true);
            Assert.Contains("ppt", results);
        }

        [Fact]
        public void PowerPointPptx()
        {
            var path = Path.Combine(Local, "sniffer.pptx");
            var results = Sniffer.Match(path, 20, true);
            Assert.Contains("pptx", results);
        }

        [Fact]
        public void Zip()
        {
            var path = Path.Combine(Local, "sniffer.zip");
            var results = Sniffer.Match(path, 20, true);
            Assert.Contains("zip", results);
        }

        [Fact]
        public void Zip7z()
        {
            var path = Path.Combine(Local, "sniffer.7z");
            var results = Sniffer.Match(path, 20, true);
            Assert.Contains("7z", results);
        }

        [Fact]
        public void Tiff()
        {
            var path = Path.Combine(Local, "sniffer.tiff");
            var results = Sniffer.Match(path, 20, true);
            Assert.Contains("tiff", results);
        }

        [Fact]
        public void Rtf()
        {
            var path = Path.Combine(Local, "sniffer.rtf");
            var results = Sniffer.Match(path, 20, true);
            Assert.Contains("rtf", results);
        }
        
        [Fact]
        public void Ps()
        {
            var path = Path.Combine(Local, "sniffer.ps");
            var results = Sniffer.Match(path, 20, true);
            Assert.Contains("ps", results);
        }
    }
}