﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCandidate.Data.Components
{
    class CampaignActivity
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
       public Campaign Campaign { get; set; }
    }
}
