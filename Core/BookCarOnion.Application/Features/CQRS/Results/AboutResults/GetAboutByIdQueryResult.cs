﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCarOnion.Application.Features.CQRS.Results.AboutResults
{
    public class GetAboutByIdQueryResult
    {
        public int AboutID { get; set; }
        public string AboutTitle { get; set; }
        public string AboutDescription { get; set; }
        public string AboutImageUrl { get; set; }
    }
}
