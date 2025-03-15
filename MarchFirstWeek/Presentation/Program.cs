using Business.Abstracts;
using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using DataAccess.Concretes.InMemory;
using Entities.Concretes;
using Entities.Concretes.Dtos;
using System.Linq;

IProgrammingLanguageService languageManager = new ProgrammingLanguageManager(new ProgrammingLanguageDal());
ITechnologyService technologyManager = new TechnologyManager(new TechnologyDal(), languageManager);

while (true)
{
    Console.Clear();
    Console.WriteLine("=== Yazılım Teknolojileri Yönetim Paneli ===");
    Console.WriteLine("1. Programlama Dilleri İşlemleri");
    Console.WriteLine("2. Teknoloji İşlemleri");
    Console.WriteLine("0. Çıkış");
    Console.Write("Seçiminiz: ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            ProgrammingLanguageMenu();
            break;
        case "2":
            TechnologyMenu();
            break;
        case "0":
            return;
        default:
            Console.WriteLine("Geçersiz seçim!");
            break;
    }

    Console.WriteLine("Devam etmek için bir tuşa basın...");
    Console.ReadKey();
}

void ProgrammingLanguageMenu()
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("=== Programlama Dilleri İşlemleri ===");
        Console.WriteLine("1. Tüm Dilleri Listele");
        Console.WriteLine("2. Yeni Dil Ekle");
        Console.WriteLine("3. Dil Güncelle");
        Console.WriteLine("4. Dil Sil");
        Console.WriteLine("5. ID'ye Göre Dil Getir");
        Console.WriteLine("0. Ana Menüye Dön");
        Console.Write("Seçiminiz: ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                var languages = languageManager.GetAll();
                foreach (var lang in languages)
                {
                    Console.WriteLine($"ID: {lang.Id} - Ad: {lang.Name}");
                }
                break;

            case "2":
                Console.Write("Dil Adı: ");
                string name = Console.ReadLine();
                languageManager.Add(new ProgrammingLanguage { Name = name });
                Console.WriteLine("Dil başarıyla eklendi.");
                break;

            case "3":
                Console.Write("Güncellenecek Dilin ID'si: ");
                int updateId = Convert.ToInt32(Console.ReadLine());
                Console.Write("Yeni Ad: ");
                string newName = Console.ReadLine();
                languageManager.Update(new ProgrammingLanguage { Id = updateId, Name = newName });
                Console.WriteLine("Dil başarıyla güncellendi.");
                break;

            case "4":
                Console.Write("Silinecek Dilin ID'si: ");
                int deleteId = Convert.ToInt32(Console.ReadLine());
                languageManager.Delete(new ProgrammingLanguage { Id = deleteId });
                Console.WriteLine("Dil başarıyla silindi.");
                break;

            case "5":
                Console.Write("Getirilecek Dilin ID'si: ");
                int getId = Convert.ToInt32(Console.ReadLine());
                var language = languageManager.GetById(getId);
                if (language != null)
                {
                    Console.WriteLine($"ID: {language.Id} - Ad: {language.Name}"); 
                }
                else
                {
                    Console.WriteLine("Belirtilen ID'ye sahip programlama dili bulunamadı!");
                }
                break;

            case "0":
                return;
        }

        Console.WriteLine("Devam etmek için bir tuşa basın...");
        Console.ReadKey();
    }
}

void TechnologyMenu()
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("=== Teknoloji İşlemleri ===");
        Console.WriteLine("1. Tüm Teknolojileri Listele");
        Console.WriteLine("2. Yeni Teknoloji Ekle");
        Console.WriteLine("3. Teknoloji Güncelle");
        Console.WriteLine("4. Teknoloji Sil");
        Console.WriteLine("5. ID'ye Göre Teknoloji Getir");
        Console.WriteLine("0. Ana Menüye Dön");
        Console.Write("Seçiminiz: ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                List<TechnologyListDto> technologies = technologyManager.GetAllWithDetails();
                foreach (TechnologyListDto tech in technologies)
                {
                    Console.WriteLine($"ID: {tech.Id} - Ad: {tech.Name} - Programlama Dili: {tech.ProgrammingLanguageName}");
                }
                break;

            case "2":
                Console.WriteLine("Mevcut Programlama Dilleri:");
                List<ProgrammingLanguage> languages = languageManager.GetAll();
                foreach (ProgrammingLanguage lang in languages)
                {
                    Console.WriteLine($"ID: {lang.Id} - Ad: {lang.Name}");
                }

                Console.Write("Teknoloji Adı: ");
                string name = Console.ReadLine();
                Console.Write("Programlama Dili ID: ");
                int langId = Convert.ToInt32(Console.ReadLine());
                technologyManager.Add(new Technology { Name = name, ProgrammingLanguageId = langId });
                Console.WriteLine("Teknoloji başarıyla eklendi.");
                break;

            case "3":
                Console.Write("Güncellenecek Teknolojinin ID'si: ");
                int techUpdateId = Convert.ToInt32(Console.ReadLine());
                Console.Write("Yeni Ad: ");
                string techNewName = Console.ReadLine();
                Console.Write("Yeni Programlama Dili ID: ");
                int newLangId = Convert.ToInt32(Console.ReadLine());
                technologyManager.Update(new Technology { Id = techUpdateId, Name = techNewName, ProgrammingLanguageId = newLangId });
                Console.WriteLine("Teknoloji başarıyla güncellendi.");
                break;

            case "4":
                Console.Write("Silinecek Teknolojinin ID'si: ");
                int techDeleteId = Convert.ToInt32(Console.ReadLine());
                technologyManager.Delete(new Technology { Id = techDeleteId });
                Console.WriteLine("Teknoloji başarıyla silindi.");
                break;

            case "5":
                Console.Write("Getirilecek Teknolojinin ID'si: ");
                int techGetId = Convert.ToInt32(Console.ReadLine());
                TechnologyListDto technology = technologyManager.GetByIdWithDetails(techGetId);
                if (technology != null)
                {
                    Console.WriteLine($"ID: {technology.Id} - Ad: {technology.Name} - Programlama Dili: {technology.ProgrammingLanguageName}");
                }
                else
                {
                    Console.WriteLine("Belirtilen ID'ye sahip teknoloji bulunamadı!");
                }
                break;

            case "0":
                return;
        }

        Console.WriteLine("Devam etmek için bir tuşa basın...");
        Console.ReadKey();
    }
}
