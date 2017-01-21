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
        IDocumentParserService DocumentServiceParser { get; }

        public DocumentsController(IDocumentService _documentService)
        {
            DocumentService = _documentService;
        }

        private readonly string root = HttpContext.Current.Server.MapPath("~/WebApi/App_Data/");

        [HttpPost]
        [Route("")]
        public IHttpActionResult Add()
        {
            try
            {
                var provider = new MultipartFormDataStreamProvider(root);

                var filesReadToProvider = Request.Content.ReadAsMultipartAsync(provider);

                foreach (var file in provider.FileData)
                {
                    var fileName = file.Headers.ContentDisposition.FileName.Replace("\"", string.Empty);

                    Dictionary<string, string> contentControllerData = DocumentServiceParser.parseDocument(fileName);                  

                    var filePath = root + fileName;
                    var type = "";

                    if (!File.Exists(filePath))
                    {
                        type = "DRAFT";
                    }
                    else
                    {
                        type = "FINAL";
                    }

                    byte[] documentData;

                    documentData = File.ReadAllBytes(file.LocalFileName);

                    var version = "0.1";

                    DocumentService.AddDocument(fileName, type, version);

                }
                return Ok(new { Message = "Document uploaded ok" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.GetBaseException().Message);
            }

        }

        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            var documents = new List<DocumentApiDto>();
            var docs = DocumentService.GetAll();
            documents = docs.Select(d => d.ToDocumentApiDto()).ToList();
            return Ok(new { Documents = documents });
        }

    }
}


