﻿using Contracts.Dtos;
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

        public static DocumentDto ToDocumentDto(this Document model)
        {
            return new DocumentDto()
            {
                Id = model.Id,
                Name = model.Name,
                Type = model.Type,
                AddedDate = model.AddedDate,
                UpdatedDate = model.UpdatedDate,
                PersonId = model.Person.Id,
                PrincipalDocumentId = 1,
                Version = model.Version
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