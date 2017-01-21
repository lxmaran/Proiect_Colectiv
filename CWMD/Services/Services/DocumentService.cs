using Contracts.IServices;
using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class DocumentService: IDocumentService
    {
        private readonly IMyDbContext context;

        public DocumentService()
        {
            this.context = new MyDbContext();
        }

        public void AddDocument(string fileName, string type, string version)
        {
            Document doc = new Document()
            {
                Name = fileName,
                Type = type,
                Version = version,
                PersonId = 1
            };

            context.Documents.Add(doc);
            context.SaveChanges();

        }

        public User GetCurrentUser()
        {
            string username = Environment.UserName;
            var user = context.Users.FirstOrDefault(u => u.UserName.Equals(username));
            return user;
        }

        public IEnumerable<Document> GetAll()
        {
            var docs = context.Documents.ToList();
            return docs;
        }

        public IEnumerable<Document> GetAllWithoutFlow()
        {
            var documentsWithFlow = (from d in context.Documents
                             join t in context.Tasks on d.Id equals t.PrincipalDocumentId
                             select d.Id).ToList();
            var documents = context.Documents.Where(d => !documentsWithFlow.Contains(d.Id))
                .ToList();
            return documents;
        }
    }
}
