using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.IServices
{
    public interface IDocumentParserService
    {
        Dictionary<string, string> parseDocument(string fileName);
    }
}
