using System;
using System.Collections.Generic;

namespace SOLID.SRP.Intermediate
{
    public class ErrorReport
    {
        public DateTime DateTime { get; set; }

        public List<string> Errors { get; set; }
    }
}
