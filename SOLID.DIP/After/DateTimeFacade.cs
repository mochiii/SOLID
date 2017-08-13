using System;

namespace SOLID.DIP.After
{
    public class DateTimeFacade : IDateTimeFacade
    {
        public DateTime Now => DateTime.Now;

        public DateTime Parse(string s) => DateTime.Parse(s);
    }
}
