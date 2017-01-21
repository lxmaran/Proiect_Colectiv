using Contracts.Dtos;
using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Models;

namespace WebApi.DtoConverter
{
    public static class DtoConverter
    {
        public static DocumentDto ToDocumentDto(this DocumentApiDto model)
        {
            return new DocumentDto()
            {
                Id = model.Id,
                Name = model.Name,
                Type = model.Type,
                AddedDate = model.AddedDate,
                UpdatedDate = model.UpdatedDate,
                PersonId = model.Person.Id,
                PrincipalDocumentId = model.Document.Id,
                Version = model.Version
            };
        }

        public static WorkZoneDocumentsDto ToWorkZoneDocumentDto(this Document model)
        {
            return new WorkZoneDocumentsDto()
            {
                Id = model.Id,
                Name = model.Name,
                Status = model.Type,
                Flow = "set after parsing the uploaded document"
            };
        }
    }
}