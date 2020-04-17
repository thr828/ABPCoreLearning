using System;
using System.Collections.Generic;
using System.Text;
using Abp.Runtime.Validation;
using ABPCoreLearning.Dto;

namespace ABPCoreLearning.PhoneBooks.Phone.Dtos
{
    public class GetPersonInput:PagedAndSortedInputDto,IShouldNormalize
    {
        public string FilterText { get; set; }
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Id";
            }
        }
    }
}
