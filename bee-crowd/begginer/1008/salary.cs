using System; 

class URI {
    static void Main(string[] args) {
        int A = Convert.ToInt32(Console.ReadLine().Trim());
        int B = Convert.ToInt32(Console.ReadLine().Trim());
        double C = Convert.ToDouble(Console.ReadLine().Trim());
        
        double SALARY = B * Math.Round(C, 2);
        
        Console.WriteLine($"NUMBER = {A}");
        Console.WriteLine($"SALARY = U$ {string.Format("{0:0.00}", Math.Round(SALARY, 2))}");
    }
}