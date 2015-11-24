namespace Chef
{
    public class MainProgram
    {
        static void Main()
        {
            Potato potato = new Potato();

            if (potato != null)
            {
                bool notPeerled = !potato.IsPeeled;
                bool notRotten = !potato.IsRotten;

                if (notPeerled && notRotten)
                {
                    potato.Cook();
                }
            }

            int minX = 5;
            int maxX = 15;
            int minY = 5;
            int maxY = 15;
            int x = 7;
            int y = 8;
            bool shouldNotVisitCell = true;

            if (x >= minX && (x <= maxX && ((maxY >= y && minY <= y) &&
                !shouldNotVisitCell)))
            {
                VisitCell();
            }
        }

        public static void VisitCell()
        {
            System.Console.WriteLine("The cell is visited!");
        }
    }
}
