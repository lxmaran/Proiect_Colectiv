using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using Contracts.Dtos;
using Contracts.IServices;
using Dal;
using Services.Services;
using WebApi.DtoConverter;
using WebApi.Models;
using Task = System.Threading.Tasks.Task;


namespace WebApi.Controllers
{
    [RoutePrefix("api/documents")]
    public class DocumentsController : ApiController
    {
        IDocumentService DocumentService { get; }
        IDocumentParserService DocumentParserService { get; }

        public DocumentsController(IDocumentService _documentService, IDocumentParserService _documentParser)
        {
            DocumentService = _documentService;
            DocumentParserService = _documentParser;
        }

        private readonly string root = HttpContext.Current.Server.MapPath("~/App_Data/");

        [HttpPost]
        public IHttpActionResult Add(Documnet document)
        {
            byte[] data = Convert.FromBase64String(document.Data.Split(',').Last());
            var str = Encoding.UTF8.GetString(data);
            var g = Guid.NewGuid();
            document.Name = g.ToString() + document.Name;
            var filePath = Path.Combine(root, document.Name);
            File.WriteAllBytes(filePath, data);
            DocumentService.AddDocument(document.Name, "DRAFT", "1.0");
            var result = DocumentParserService.DetermineFlowType(filePath);
            return Ok();
        }

        public IHttpActionResult GetAllDocuments()
        {
            var documents = DocumentService.GetAllWithoutFlow();
            var docs = new List<DocumentDto>();

            foreach (var model in documents)
            {
                var flowType = DocumentParserService.DetermineFlowType(Path.Combine(root, model.Name));
                var docDto = new DocumentDto
                {
                    Id = model.Id,
                    Name = model.Name,
                    Type = model.Type,
                    AddedDate = model.AddedDate,
                    UpdatedDate = model.UpdatedDate,
                    PersonId = model.Person.Id,
                    PrincipalDocumentId = 1,
                    Version = model.Version,
                    Flow = flowType.Type,
                    FlowId = flowType.Id,
                };
                docs.Add(docDto);
            }


            return Ok(docs);
        }
    }
}