using System;

namespace SqlIntro
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public int Reload { get; set; }
        public double Profits { get; set; }
        public DateTime StartDateTime { get; set; }
        public int ProductDev { get; set; }
    }
}