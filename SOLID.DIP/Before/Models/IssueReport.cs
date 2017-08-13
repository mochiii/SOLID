using System;
using System.Collections.Generic;

namespace SOLID.DIP.Before.Models
{
    public class IssueReport
    {
        public DateTime DateTime { get; set; }

        public List<IIssue> Issues { get; set; }
    }
}
