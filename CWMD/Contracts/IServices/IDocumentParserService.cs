using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.IServices
{
    public interface IDocumentParserService
    {
        FlowType DetermineFlowType(string fileName);
    }
}
