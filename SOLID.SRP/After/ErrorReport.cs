using System;
using System.Collections.Generic;

namespace SOLID.SRP.After
{
    public class ErrorReport
    {
        public DateTime DateTime { get; set; }

        public List<string> Errors { get; set; }
    }
}
