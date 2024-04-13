using System; 

class URI {
    static void Main(string[] args) {
        double A = Convert.ToDouble(Console.ReadLine().Trim());
        double B = Convert.ToDouble(Console.ReadLine().Trim());
        
        double MEDIA = (3.5 * Math.Round(A, 1) + 7.5 * Math.Round(B, 1)) / 11;
        
        Console.WriteLine($"MEDIA = {string.Format("{0:0.00000}", Math.Round(MEDIA, 5))}");
    }
}