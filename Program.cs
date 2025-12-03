// Tampilkan "Fizz" jika habis dibagi 3
// Tampilkan "Buzz" jika habis dibagi 5
// Tampilkan "FizzBuzz" jika habis dibagi 3 dan 5

Console.WriteLine("=== FizzBuzz Program (Tabel) ===\n");

for (int i = 1; i <= 100; i += 5) 
{
    string row = "";
    
    for (int j = 0; j < 5 && (i + j) <= 100; j++) 
    {
        int num = i + j;
        string result;
        
        if (num % 15 == 0) // Cek kelipatan 3 dan 5
        {
            result = "FizzBuzz";
        }
        else if (num % 3 == 0) // Cek kelipatan 3
        {
            result = "Fizz";
        }
        else if (num % 5 == 0) // Cek kelipatan 5
        {
            result = "Buzz";
        }
        else
        {
            result = num.ToString();
        }
        
        row += $"{result.PadRight(10)} ";
    }
    
    Console.WriteLine(row);
}