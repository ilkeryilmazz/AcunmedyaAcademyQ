//C#’ta kullanılan temel veri tipleri nelerdir? (int, double, string vb.)
//String metinsel ifadeleri tutar.
//Int tam sayıları tutar.
//Double ondalıklı sayıları tutar.
//Char karakterleri tutar.
//Bool true ya da false değerlerini tutar.
//Decimal ondalıklı sayıları tutar.
//Float ondalıklı sayıları tutar.
//Byte 0-255 arasındaki tam sayıları tutar.
//Short -32,768 ile 32,767 arasındaki tam sayıları tutar.
//Long -9,223,372,036,854,775,808 ile 9,223,372,036,854,775,807 arasındaki tam sayıları tutar.
//Ushort 0 ile 65,535 arasındaki tam sayıları tutar.
//Uint 0 ile 4,294,967,295 arasındaki tam sayıları tutar.
//Ulong 0 ile 18,446,744,073,709,551,615 arasındaki tam sayıları tutar.
//Sbyte -128 ile 127 arasındaki tam sayıları tutar.
//Object her türlü veriyi tutabilir.


// int bellek kullanımı 4 byte
// double bellek kullanımı 8 byte
// string bellek kullanımı 2 byte * karakter sayısı



Console.Write("Enter a first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int result = firstNumber + secondNumber;
Console.WriteLine("Result: " + result);