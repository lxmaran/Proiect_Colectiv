using Contracts.IServices;
using Dal;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Services.Services
{
    public class DocumentParserService : IDocumentParserService
    {

        private readonly IMyDbContext context;

        public DocumentParserService(IMyDbContext _context)
        {
            context = _context;
        }

        public Dictionary<string,string> parseDocument(string fileName)
        {
            Dictionary<string, string> contentControllerData = new Dictionary<string, string>();

            using (WordprocessingDocument doc = WordprocessingDocument.Open(fileName, false))
            {
                foreach (var cc in doc.ContentControls())
                {
                    SdtProperties props = cc.Elements<SdtProperties>().FirstOrDefault();
                    Tag tag = props.Elements<Tag>().FirstOrDefault();
                    
                    contentControllerData.Add(tag.Val, cc.InnerText);                    
                }
            }

            return contentControllerData;
        }
    }
}
