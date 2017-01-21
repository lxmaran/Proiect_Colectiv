using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using Contracts.Dtos;
using Contracts.IServices;
using Dal;
using WebApi.DtoConverter;
using WebApi.Models;
using Task = System.Threading.Tasks.Task;


namespace WebApi.Controllers
{
    [RoutePrefix("api/documents")]
    public class DocumentsController : ApiController
    {
        IDocumentService DocumentService { get; }

        public DocumentsController(IDocumentService _documentService)
        {
            DocumentService = _documentService;
        }

        private readonly string root = HttpContext.Current.Server.MapPath("~/WebApi/App_Data/");

        [HttpPost]
        public IHttpActionResult Add()
        {
            try
            {
                var provider = new MultipartFormDataStreamProvider(root);

                var filesReadToProvider = Request.Content.ReadAsMultipartAsync(provider);

                foreach (var file in provider.FileData)
                {
                    var fileName = file.Headers.ContentDisposition.FileName.Replace("\"", string.Empty);
                    var filePath = root + fileName;
                    string version = "";

                    if (!File.Exists(filePath))
                    {
                        version = "DRAFT";
                    }
                    else
                    {
                        version = "FINAL";
                    }

                    byte[] documentData;

                    documentData = File.ReadAllBytes(file.LocalFileName);

                    var type = Path.GetExtension(fileName);

                    DocumentService.AddDocument(fileName, type, version);

                }
                return Ok(new { Message = "Document uploaded ok" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.GetBaseException().Message);
            }

        }

        public IHttpActionResult GetAllDocuments()
        {
            var documents = new List<WorkZoneDocumentsDto>();        
            var docs = DocumentService.GetAll();
            documents = docs.Select(d => d.ToWorkZoneDocumentDto()).ToList();                
            return Ok(new { Documents = documents });
        }

        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(new List<DocumentApiDto>
            {
                new DocumentApiDto
                {
                    Id = 1,
                    Name = "Doc1",
                    Type = "type1",
                    AddedDate = DateTime.Today,
                    UpdatedDate = DateTime.Today,
                    PersonId = 1,
                    Person = new Person()
                    {
                        Id = 1,
                        FirstName = "Aurel",
                        LastName = "Dubas",
                    },
                    Version = "lastVersion",
                    Flow = "flow 1"
                },
                new DocumentApiDto
                {
                    Id = 2,
                    Name = "Doc2",
                    Type = "type2",
                    AddedDate = DateTime.Today,
                    UpdatedDate = DateTime.Today,
                    PersonId = 1,
                    Person = new Person()
                    {
                        Id = 1,
                        FirstName = "Aurel",
                        LastName = "Dubas",
                    },
                    Version = "some version",
                    Flow = "flow 2"
                }
            });
        }

    }
}