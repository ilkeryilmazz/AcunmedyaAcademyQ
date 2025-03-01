using LoopsAndFunctions;

Console.WriteLine("Proccess: 1- Example For Number Sum With For Loop");
Console.WriteLine("Proccess: 2- Example For Get Valid Number With While Loop");
Console.WriteLine("Proccess: 3- Example For Get Age Category(Adult, Teenager, Child) With Foreach Loop");
Console.WriteLine("Proccess: 4- Example For DuplicatedElements In Array");
Console.WriteLine("Proccess: 5- Example For Find Longest Word And Shorest Word In Array");
Console.WriteLine("Proccess: 6- Example For Convert Sentence Convert To Array And Sort");
Console.WriteLine("Proccess: 7- Example For Expandable String Array");
Console.WriteLine("Proccess: 8- Example For Reverse Word List");
Console.WriteLine("Proccess: 9- Example For Sort Number List And Get Averege");
Console.WriteLine("Proccess: 10- Example For Number Filtering (number > 10)");
Console.WriteLine("Proccess: 11- Example For Update Grades Which One Is < 50");

Console.Write("Enter a proccess number: ");
var selectedProccess = Convert.ToInt32(Console.ReadLine());


switch (selectedProccess)
{
    case 1:
        NumberSumWithFor.Sum();
        break;
    case 2:
        GetNumberWithWhile.Get();
        break;
    case 3:
        AgeDetermine.Determine();
        break;
    case 4:
        DuplicatedElement.FindDuplicates();
        break;
    case 5:
        LongestAndShortestWord.Find();
        break;
    case 6:
        SentenceToArrayAndSort.ConvertAndShort();
        break;
    case 7:
        ExpandableStringArray.Run();
        break;
    case 8:
        ReverseWordList.Reverse();
        break;
    case 9:
        NumberList.NumberSortAndGetAvarege();
        break;
    case 10:
        NumberFilter.Filter();
        break;
    case 11:
        GradeUpdater.Update();
        break;
    default:
		break;
}


// Metot nedir: Metotlar (Fonksiyonlar) kodumuzun tekrar kullanılabilirliğini arttırmak ve işlevsel küçük parçalara bölmek için kullandığımız yapılardır.
// Metotları neden kullanırız: Metotları kullanmamızın başlıca sebebi uygulamamızın sürdürülebiliriğini ve büyük kod karmaşıklığını kontrol edilebilir düzeyde tutmak içindir.
// Geri değer döndüren metotlar: Metotlarda return ile geriye değer döndürmesi yapılabilir bu ise metot sonucu oluşan ya da değiştirilen veriyi daha sonrasında kullanabilmemiz için gereklidir. Void ise bu şekilde bir şey sağlamaz.
// Metotların paremetleri nasıl çalıştırılır: Metot parametleri metod çağırıldığında metota gönderdiğimzi değerlerdir örnek olarak Console.WriteLine("Merhaba"); burada WriteLine metodu bir parametre alır ve bu parametre string türündedir.