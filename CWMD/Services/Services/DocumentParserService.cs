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
        private IMyDbContext context;

        public DocumentParserService()
        {
            context = new MyDbContext();
        }

        public FlowType DetermineFlowType(string fileName)
        {
            var parseResult = ParseDocument(fileName);
            var functie = parseResult["functie"].Replace("[", "").Replace("]", "");
            var cheltuieliAferente = parseResult["cheltuieliAferente"].Replace("[", "").Replace("]", "");
            var flowType = context.FlowTypes.FirstOrDefault(f => f.Type.ToLower().Contains(functie.ToLower()) && f.Type.ToLower().Contains(cheltuieliAferente.ToLower()));
            return flowType;
        }

        private Dictionary<string, string> ParseDocument(string fileName)
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
