using System; 

class URI {

    static void Main(string[] args) { 
        int A = Convert.ToInt32(Console.ReadLine().Trim());
        int B = Convert.ToInt32(Console.ReadLine().Trim());
        int C = Convert.ToInt32(Console.ReadLine().Trim());
        int D = Convert.ToInt32(Console.ReadLine().Trim());
        
        int DIFERENCA = A * B - C * D;
        
        Console.WriteLine($"DIFERENCA = {DIFERENCA}");
    }
}