using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class DocumentService
    {
        private readonly IMyDbContext context;

        public DocumentService(IMyDbContext context)
        {
            this.context = context;
        }

        void AddDocument(string fileName, string type, string version)
        {
            Document doc = new Document()
            {
                Name = fileName,
                Type = type,
                Version = version,
                PersonId = GetCurrentUser().Id
            };

            context.Documents.Add(doc);
            context.SaveChanges();

        }

        private User GetCurrentUser()
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
    }
}
