using Contracts.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;

namespace Services.Services
{
    public class AnswerService : IAnswerService
    {
        private readonly IMyDbContext context;

        public AnswerService()
        {
            this.context = new MyDbContext();
        }

        public IEnumerable<Answare> GetAll()
        {
            var answers = context.Answares.ToList() ;
            return answers;
        }

        public Answare GetAnswer(int id)
        {
            var answer = context.Answares.Where(u => u.Id == id )
               .FirstOrDefault();
            return answer;
        }
    }
}
