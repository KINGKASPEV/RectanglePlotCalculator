namespace Assessment
{
    public class Rectangle
    {
        public decimal Length {  get; set; }
        public decimal Breadth { get; set; }

        public Rectangle(decimal length, decimal breadth)
        {
            Length = length;
            Breadth = breadth;
        }

        public decimal Area()
        {
            return Length * Breadth;
        }

       
    }

    public class Cost : Rectangle
    {
        private decimal CostPerArea {  get; set; }

        public Cost(decimal length, decimal breadth, decimal costPerArea)
            : base(length, breadth)
        {
            CostPerArea = costPerArea;
        }

        public decimal GetCost()
        {
            decimal area = Area();
            return area * CostPerArea;
        }

        public void CostOutput()
        {
            decimal cost = GetCost();
            Console.WriteLine($"Cost for rectangle plot is: {cost}");
        }
    }
}
