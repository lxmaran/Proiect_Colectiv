using Contracts.Dtos;
using Dal;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Models;

namespace WebApi.DtoConverter
{
    public static class DtoConverter
    {

        public static DocumentService docService { get; }
       
        public static DocumentApiDto ToDocumentApiDto(this Document model)
        {
            return new DocumentApiDto()
            {
                Id = model.Id,
                Name = model.Name,
                Type = model.Type,
                
                AddedDate = DateTime.Now ,
                UpdatedDate = DateTime.Now,
                PersonId = docService.GetCurrentUser().Id,
                PrincipalDocumentId = 1,
                Version = model.Version,
                Flow = "set after parsing",
            };
        }

        public static AnswerDto ToAnswerDto( this Answare model)
        {
            return new AnswerDto()
            {
                AnswerId = model.Id,
                Name = model.Name
            };
        }
    }
}