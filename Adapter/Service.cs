using System;

namespace Assignment2.Adapter
{
    public class Service : IService
    {
        private ReturningStrings returningStrings { get; set; }
        private PrintingInts printingInts { get; set; }

        public Service()
        {
            returningStrings = new();
            printingInts = new();
        }

        public int Convert()
        {
            var number = Int32.Parse(returningStrings.ReturnString());
            return number;
        }

        public void Print()
        {
            printingInts.Print(Convert());
        }
    }
}