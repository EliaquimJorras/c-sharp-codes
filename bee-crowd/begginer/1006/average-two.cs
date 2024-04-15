using System; 

class URI {
    static void Main(string[] args) {
        double A = Convert.ToDouble(Console.ReadLine().Trim());
        double B = Convert.ToDouble(Console.ReadLine().Trim());
        double C = Convert.ToDouble(Console.ReadLine().Trim());
        
        double MEDIA = (2.0 * Math.Round(A, 1) + 3.0 * Math.Round(B, 1) + 5.0 * Math.Round(C, 1)) / 10;
        
        Console.WriteLine($"MEDIA = {string.Format("{0:0.0}", Math.Round(MEDIA, 1))}");
    }
}