using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Abp.AutoMapper;
using ABPCoreLearning.PhoneBooks.Persons;
using ABPCoreLearning.PhoneBooks.PhoneNumbers;

namespace ABPCoreLearning.PhoneBooks.Phone.Dtos
{
    [AutoMapFrom(typeof(Person))]
    public class PersonEditDto
    {
        public int? Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [EmailAddress]
        [MaxLength(50)]
        public string EmailAddress { get; set; }
        [MaxLength(200)]
        public string Address { get; set; }

        public List<PhoneNumber> PhoneNumbers { get; set; }
    }
}
