using System;
using Dal;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Contracts.IServices
{
   public interface IAnswerService
    {
        IEnumerable<Answare> GetAll();

        Answare GetAnswer(int id);

        int GetIdByName(string answerName);
    }
}
