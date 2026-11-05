Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артем", 120);

Console.WriteLine($"До вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");

yaroslav.TakeDamage(25);
anastasia.TakeDamage(30);

Console.WriteLine($"После вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");

yaroslav.TakeDamage(-20);
Console.WriteLine($"После неверного урона: {yaroslav.Health}");

artem.TakeDamage(200);
Console.WriteLine($"После сильного урона, Артём: {artem.Health}");

yaroslav.Heal(10);
yaroslav.GainExperience(40);
yaroslav.GainExperience(25);

Console.WriteLine($"После лечения, Ярослав: {yaroslav.Health}");
Console.WriteLine($"Опыт Ярослава: {yaroslav.Experience}");

bool yaroslavAlive = yaroslav.IsAlive();
Console.WriteLine($"Ярослав жив: {yaroslavAlive}");
Console.WriteLine($"Артём жив: {artem.IsAlive()}");

if (yaroslavAlive)
{
    Console.WriteLine("Ярослав может продолжать приключение.");
}
else
{
    Console.WriteLine("Ярослав больше не может сражаться.");
}

string info = yaroslav.GetInfo();
Console.WriteLine("Строка получена. Сейчас выведем её:");
Console.WriteLine(info);

Console.WriteLine();
Console.WriteLine(anastasia.GetInfo());
Console.WriteLine();
Console.WriteLine(artem.GetInfo());


//yaroslav.Health = 75;

Console.WriteLine(">>> Герой 1 <<<");
Console.WriteLine($"Имя: {yaroslav.Name}");
Console.WriteLine($"Здоровье: {yaroslav.Health}");
Console.WriteLine($"Уровень: {yaroslav.Level}");
Console.WriteLine($"Опыт: {yaroslav.Experience}");

Console.WriteLine();

Console.WriteLine(">>> Герой 2 <<<");
Console.WriteLine($"Имя: {anastasia.Name}");
Console.WriteLine($"Здоровье: {anastasia.Health}");
Console.WriteLine($"Уровень: {anastasia.Level}");
Console.WriteLine($"Опыт: {anastasia.Experience}");

Console.WriteLine();

Console.WriteLine(">>> Герой 3 <<<");
Console.WriteLine($"Имя: {artem.Name}");
Console.WriteLine($"Здоровье: {artem.Health}");
Console.WriteLine($"Уровень: {artem.Level}");
Console.WriteLine($"Опыт: {artem.Experience}");
Game witcher = new Game("Ведьмак 3", "RPG", 2015);
Game minecraft = new Game("Minecraft", "Sandbox", 2011);
Game portal = new Game("Portal 2", "Puzzle", 2011);

witcher.Rating = 9.8; // рейтинг можно поменять потом

Console.WriteLine(">>> Игра 1 <<<");
Console.WriteLine($"Название: {witcher.Title}");
Console.WriteLine($"Жанр: {witcher.Genre}");
Console.WriteLine($"Год выхода: {witcher.ReleaseYear}");
Console.WriteLine($"Рейтинг: {witcher.Rating}");

Console.WriteLine();

Console.WriteLine(">>> Игра 2 <<<");
Console.WriteLine($"Название: {minecraft.Title}");
Console.WriteLine($"Жанр: {minecraft.Genre}");
Console.WriteLine($"Год выхода: {minecraft.ReleaseYear}");
Console.WriteLine($"Рейтинг: {minecraft.Rating}");

Console.WriteLine();

Console.WriteLine(">>> Игра 3 <<<");
Console.WriteLine($"Название: {portal.Title}");
Console.WriteLine($"Жанр: {portal.Genre}");
Console.WriteLine($"Год выхода: {portal.ReleaseYear}");
Console.WriteLine($"Рейтинг: {portal.Rating}");

Console.WriteLine($"Часов в {witcher.Title} до: {witcher.PlayTime}");
witcher.AddPlayTime(15);
Console.WriteLine($"Часов в {witcher.Title} после нормы: {witcher.PlayTime}");
witcher.AddPlayTime(-5);
Console.WriteLine($"Часов в {witcher.Title} после ошибки: {witcher.PlayTime}");