using ObjectOriantdProgramming.Entities.BankAccount;
using ObjectOriantdProgramming.Entities.Employee;

Employee developer = new Developer(1,"İlker Yılmaz",10000, "IT", "Full Stack Developer");
Employee manager = new Manager(2, "Muhammed İnan", 22000, "IT", 250);

Console.WriteLine($"Developer Salary: {developer.CalculateSalary()}");
Console.WriteLine($"Manager Salary: {manager.CalculateSalary()}");


BankAccount savingsAccount = new SavingsAccount(1, "İlker Yılmaz", 1000);
BankAccount checkingAccount = new CheckingAccount(2, "Muhammed İnan", 2000);

Console.WriteLine($"Savings Account Interest: {savingsAccount.CalculateInterest()}");

System.Threading.Thread.Sleep(5000);

Console.WriteLine($"Checking Account Interest: {checkingAccount.CalculateInterest()}");


//Abstract class, ortak özellikleri ve metotları içeren sınıflardır ancak doğrudan nesne olarak oluşturulamazlar.
//Interface, bir sınıfın hangi metotları ya da özellikleri içermesi gerektiğini belirleyen, sadece metot imzalarını içeren bir yapıdır.
//Farkları: Abstract class hem tamamlanmış hem de tamamlanmamış metotlar içerebilirken, interface sadece metot imzalarını barındırır ve bir sınıf birden fazla interface’i uygulayabilir, ancak sadece bir abstract class’tan miras alabilir.