using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.IServices
{
    public interface IDocumentService
    {
        IEnumerable<Document> GetAll();
        IEnumerable<Document> GetAllWithoutFlow();
        void AddDocument(string fileName, string type, string version);
        User GetCurrentUser();
    }
}
