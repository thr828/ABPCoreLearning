﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Abp.Application.Services.Dto;

namespace ABPCoreLearning.Dto
{
    public class PagedAndSortedInputDto : IPagedResultRequest, ISortedResultRequest
    {
        [Range(0,int.MaxValue)]
        public int SkipCount { get; set; }
        [Range(1,500)]
        public int MaxResultCount { get; set; }
        public string Sorting { get; set; }
    }
}
