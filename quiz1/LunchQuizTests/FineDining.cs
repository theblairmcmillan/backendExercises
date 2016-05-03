using System;

namespace LunchQuizTests
{
    internal class FineDining
    {
        public int Numberof2PersonTables { get; internal set; }
        public int Numberof4PersonTables { get; internal set; }
        public int NumberofSeatsAtBar { get; internal set; }

        internal int capacity()
        {
            throw new NotImplementedException();
        }
    }
}