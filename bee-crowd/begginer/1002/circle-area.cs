using System; 

class URI {
    static void Main(string[] args) { 
        const double Pi = 3.14159;
        
        double R = Convert.ToDouble(Console.ReadLine().Trim());
        
        double A = Pi * Math.Pow(Math.Round(R, 2), 2);
        
        Console.WriteLine($"A={string.Format("{0:0.0000}",Math.Round(A, 4))}");
    }
}