using System;
using System.Collections.Generic;
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
        public async Task<IHttpActionResult> Add()
        {
            try
            {
                var provider = new MultipartFormDataStreamProvider(root);

                var filesReadToProvider = await Request.Content.ReadAsMultipartAsync(provider);

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

        public async Task<IHttpActionResult> GetAllDocuments()
        {
            var documents = new List<WorkZoneDocumentsDto>();

            await System.Threading.Tasks.Task.Factory.StartNew(() =>
            {               
                var docs = DocumentService.GetAll();
                documents = docs.Select(d => d.ToWorkZoneDocumentDto()).ToList();                
            });

            return Ok(new { Documents = documents });
        }

    }
}