using System; 

class URI {
    static void Main(string[] args) { 
        int A = Int32.Parse(Console.ReadLine().Trim());
        int B = Int32.Parse(Console.ReadLine().Trim());
        
        int X = A + B;
        
        Console.WriteLine($"X = {X}");
    }
}