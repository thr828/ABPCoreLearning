using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services.Dto;
using ABPCoreLearning.PhoneBooks.PhoneNumbers;

namespace ABPCoreLearning.PhoneBooks.Phone.Dtos
{
    public class PersonListDto:FullAuditedEntityDto
    {
        public string Name { get; set; }

        public string EmailAddress { get; set; }

        public string Address { get; set; }

        public List<PhoneNumber> PhoneNumbers { get; set; }
    }
}
