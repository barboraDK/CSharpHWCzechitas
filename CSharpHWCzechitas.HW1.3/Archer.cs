namespace CSharpHWCzechitas.HW1
{
    public class Archer
    {
        public int arrowsNum = 10;

        public void Shot()
        {
            while (arrowsNum > 0) 
            { 
                Console.WriteLine("I'll always hit the bulls eye");
                arrowsNum--;
            }
            Console.WriteLine("I've run out of arrows");
        }
    }
}
