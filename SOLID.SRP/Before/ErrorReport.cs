using System;
using System.Collections.Generic;

namespace SOLID.SRP.Before
{
    public class ErrorReport
    {
        public DateTime DateTime { get; set; }

        public List<string> Errors { get; set; }
    }
}
