﻿using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ABPCoreLearning.PhoneBooks.Persons;
using ABPCoreLearning.PhoneBooks.PhoneNumbers;
using AutoMapper;

namespace ABPCoreLearning.PhoneBooks.Phone.Dtos
{
    [AutoMapFrom(typeof(Person))]
    public class PersonListDto:FullAuditedEntityDto
    {
        public string Name { get; set; }

        public string EmailAddress { get; set; }

        public string Address { get; set; }

        public List<PhoneNumber> PhoneNumbers { get; set; }
    }
}
