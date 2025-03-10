//Koşullu ifadeler(if-else) ne işe yarar? Gerçek hayattan bir örnek verin

// Koşullu ifadeler, programın belirli bir koşula bağlı olarak farklı işlemler yapmasını sağlar. Örneğin, ehliyet almak için belli yaş sınırları ve ekstra şartlar mevcut. Bu şartlar örnek sayılabilir.
// Programlamada ise kullanıcı girişi, yetki kontrolü vb işlemler koşula bağlı yapılabilir.

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
    Console.WriteLine("Number is even");
else
    Console.WriteLine("Number is odd");


if (number > 0)
    Console.WriteLine("Number is positive.");
else if (number < 0)
    Console.WriteLine("Number is negative.");
else
    Console.WriteLine("Number is zero.");
