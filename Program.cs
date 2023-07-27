namespace _2240._Number_of_Ways_to_Buy_Pens_and_Pencils
{
    internal class Program
    {
        static public long WaysToBuyPensPencils(int total, int cost1, int cost2)
        {
            long result = 0;
            for(int i = 0; i <= total / cost1; i++) 
            {
                result += ((total - cost1 * i) / cost2) + 1;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}