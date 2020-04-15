using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using ABPCoreLearning.PhoneBooks.Persons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ABPCoreLearning.PhoneBooks.PhoneNumbers
{
    public class PhoneNumber:Entity<long>,IHasCreationTime
    {
        [Required]
        [MaxLength(11)]
        public string Number { get; set; }

        public PhoneNumberType Type { get; set; }

        public int PersonId { get; set; }

        public Person Person { get; set; }

        public DateTime CreationTime { get; set; }
    }
}
