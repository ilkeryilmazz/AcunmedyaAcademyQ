//Döngüler (for, while) ne işe yarar? Hangisi hangi durumda kullanılır?

// Döngüler belirli bir işlemi tekrar etmek için kullanılır
// For döngüsü: Belirli bir koşul sağlandığı sürece işlemi tekrarlar. Genellikle kaç kere döngünün çalışacağı biliniyorsa kullanılır.
// While döngüsü: Belirli bir koşul sağlandığı sürece işlemi tekrarlar. Genellikle kaç kere döngünün çalışacağı bilinmiyorsa kullanılır.

Console.WriteLine("-----------------");

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("-----------------");


Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());


if (number > 0)
{
    int sum = 0;

    
    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }

    Console.WriteLine($"The sum of numbers from 1 to {number} is: {sum}");
}
else
{
    Console.WriteLine("Invalid input! Please enter a positive integer.");
}
