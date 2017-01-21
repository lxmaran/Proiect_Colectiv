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
        private IUserRepository _userRepository;
        private IBaseEntityRepository<Document> _documentRepo;

        public DocumentService(IUserRepository userRepository, IBaseEntityRepository<Document> documentRepo)
        {
            _userRepository = userRepository;
            _documentRepo = documentRepo;
        }

        void addDocument(string fileName, string type, string version)
        {
            Document doc = new Document()
            {
                Name = fileName,
                Type = type,
                Version = version,
                PersonId = _userRepository.getCurrentUser().Id
            };

            _documentRepo.Add(doc);

        }

        public IEnumerable<Document> GetAll()
        {
            var docs = _documentRepo.GetAll();
            return docs;
        }
    }
}
