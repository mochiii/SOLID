using System;

namespace SOLID.DIP.After
{
    public interface IDateTimeFacade
    {
        DateTime Now { get; }

        DateTime Parse(string s);
    }
}