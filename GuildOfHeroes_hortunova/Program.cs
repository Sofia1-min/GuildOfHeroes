//Probe.Run();
Hero alexander = new Hero("   Александр   ", 150);
Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артем", 120);
Hero sergey = new Hero("Сергей", 110);
alexander.TakeDamage(10);
alexander.Heal(10);

Console.WriteLine(yaroslav.GetInfo());
Console.WriteLine();
Console.WriteLine(anastasia.GetInfo());
Console.WriteLine();
Console.WriteLine(artem.GetInfo());
Console.WriteLine();
Console.WriteLine(alexander.GetInfo());

Guild guild = new Guild("Гильдия героев");

guild.AddHero(yaroslav);
guild.AddHero(anastasia);
guild.AddHero(artem);
guild.AddHero(yaroslav);
guild.AddHero(sergey);
//лаба 6
Console.WriteLine($">>> {guild.Name}: участников {guild.MemberCount} <<<");
Console.WriteLine();

QuestBoard board = new QuestBoard(guild);

Quest floatQuest = new Quest(101, "Вернуть поплавок", 100, 30);
Console.WriteLine($"Поручение добавлено: {board.AddQuest(floatQuest)}");
Console.WriteLine($">>> №{floatQuest.Id}: {floatQuest.Title} <<<");

Console.WriteLine($"Назначение Сергея: {board.TryAssign(101, " сЕрГеЙ ")}");
Hero? assigned = floatQuest.AssignedHero;
if (assigned != null) {
    Console.WriteLine($"Исполнитель: {assigned.Name}");
}
Console.WriteLine($"Опыт после назначения: {sergey.Experience}");

Console.WriteLine($"Завершение: {board.TryComplete(101)}");
Console.WriteLine($"Опыт после завершения: {sergey.Experience}");
Console.WriteLine($"Повторное завершение: {board.TryComplete(101)}");
Console.WriteLine($"Опыт после повтора: {sergey.Experience}");

Console.WriteLine();
Console.WriteLine(floatQuest.GetInfo());
Console.WriteLine(sergey.GetInfo());


/*
//лаба 5
List<Hero> members = guild.GetMembers();

Console.WriteLine($">>> {guild.Name}: перекличка <<<");
Console.WriteLine($"Участников: {guild.MemberCount}");

if (members.Count > 0) {
    Console.WriteLine($"Первый: {members[0].Name}");
    Console.WriteLine($"Последний: {members[members.Count - 1].Name}");
}

Console.WriteLine();
foreach (Hero hero in members)
{
    Console.WriteLine(hero.GetInfo());
    Console.WriteLine();

    Hero? found = guild.FindHeroByName(" аРтЁм ");
    if (found != null)
    {
        Console.WriteLine($"Найден по запросу « аРтЁм »: {found.Name}");
    }
    else
    {
        Console.WriteLine("По запросу « аРтЁм » никого нет.");
    }

}

Console.WriteLine($"Повтор Александра принят: {guild.AddHero(alexander)}");

Console.WriteLine($"Удалён отсутствующий: {guild.RemoveHero("Борис")}");
Console.WriteLine($"Участников после проверок: {guild.MemberCount}");
//лаба 4
// 12,1
Console.WriteLine($"Могут нести тяжёлые ящики (здоровье от 120): {guild.CountHealthy(120)}");
//12,2
Hero? strongest = guild.FindStrongest();
if (strongest != null)
{
    Console.WriteLine($"Самый здоровый: {strongest.Name} ({strongest.Health})");
}*/


//лаба 4

// лаба 3
/*Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("   Александр   ", 150);

alexander.TakeDamage(10);
alexander.Heal(10);

Console.WriteLine(">>> Участники готовы <<<");
Console.WriteLine();
Console.WriteLine(yaroslav.GetInfo());
Console.WriteLine();
Console.WriteLine(anastasia.GetInfo());
Console.WriteLine();
Console.WriteLine(artem.GetInfo());
Console.WriteLine();
Console.WriteLine(alexander.GetInfo());

Console.WriteLine($"Предел здоровья Александра: {alexander.MaxHealth}");*/

// лаба 2
/*Console.WriteLine($"До вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");

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
*/
// лаба 1
//yaroslav.Health = 75;

/*Console.WriteLine(">>> Герой 1 <<<");
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
Console.WriteLine($"Опыт: {artem.Experience}");*/

// самостоятельное задание
// --- Самостоятельное задание ---
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"Мой личный проект");
Game witcher = new Game("Геншин Импакт", "RPG", 2020);
Game minecraft = new Game("Minecraft", "Sandbox", 2011);
Game portal = new Game("Portal 2", "Puzzle", 2011);

witcher.ChangeRating(9.8);

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

Console.WriteLine($"\nЧасов в {witcher.Title} до: {witcher.PlayTime}");
witcher.AddPlayTime(15);
Console.WriteLine($"Часов в {witcher.Title} после нормы: {witcher.PlayTime}");
witcher.AddPlayTime(-5);
Console.WriteLine($"Часов в {witcher.Title} после ошибки: {witcher.PlayTime}");

Console.WriteLine("\n--- Проверка класса Game ---");

Game myGame = new Game("   Геншин Импакт   ", "RPG", 2020);
Console.WriteLine($"Игра: [{myGame.Title}], Часы: {myGame.PlayTime}");

myGame.AddPlayTime(10);
Console.WriteLine($"После игры 10 часов: {myGame.PlayTime}");

myGame.AddPlayTime(-5);
Console.WriteLine($"После попытки накрутить -5 часов: {myGame.PlayTime}");

Game badGame = new Game("   ", "Action", 2023);
Console.WriteLine($"Игра с пустым именем: [{badGame.Title}]");

Console.WriteLine("\n--- Доп. часть Г: Две игры ---");
Game game1 = new Game("   Геншин Импакт   ", "Action", 2020);
Game game2 = new Game("Minecraft", "Sandbox", 2011);

game1.ChangeRating(15);
game2.ChangeRating(-5);

Console.WriteLine($"Игра 1: {game1.Title}, Рейтинг: {game1.Rating}");
Console.WriteLine($"Игра 2: {game2.Title}, Рейтинг: {game2.Rating}");

Console.WriteLine("\n=== Список игр ===");
List<Game> games = new List<Game>();
Game listGame1 = new Game("Геншин Импакт", "RPG", 2020);
Game listGame2 = new Game("Майнкрафт", "Песочница", 2011);
Game listGame3 = new Game("GTA V", "Экшн", 2013);

games.Add(listGame1);
games.Add(listGame2);
games.Add(listGame3);

Console.WriteLine($"Всего игр: {games.Count}");
if (games.Count > 0) {
    Console.WriteLine($"Первая игра: {games[0].Title}");
    Console.WriteLine($"Последняя игра: {games[games.Count - 1].Title}");
}

foreach (Game game in games) {
    Console.WriteLine($"Игра: {game.Title}, Жанр: {game.Genre}, Часы: {game.PlayTime}");
}

games.Add(new Game("Тетрис", "Головоломка", 1984));
Console.WriteLine($"Добавили 4-ю игру. Теперь их: {games.Count}");

int modernGames = 0;
foreach (Game game in games) {
    if (game.ReleaseYear > 2012) {
        modernGames++;
    }
}
Console.WriteLine($"Игр, выпущенных после 2012 года: {modernGames}");

listGame1.AddPlayTime(50);
Console.WriteLine($"Геншин после добавления времени: {listGame1.PlayTime} ч.");
Console.WriteLine($"Проверка через список: {games[0].PlayTime} ч.");

Console.WriteLine("\n=== Каталог игр ===");
GameCatalog cat = new GameCatalog();

Console.WriteLine($"Добавлена Геншин: {cat.AddGame(new Game("Геншин Импакт", "RPG", 2020))}");
Console.WriteLine($"Повтор ' гЕншин Импакт ': {cat.AddGame(new Game("  гЕншин Импакт ", "RPG", 2020))}");

cat.AddGame(new Game("Minecraft", "Sandbox", 2011));
cat.AddGame(new Game("Portal 2", "Puzzle", 2011));

Game? foundGame = cat.FindByTitle("minecraft");
if (foundGame != null) Console.WriteLine($"Найдено: {foundGame.Title}");

Game? notFound = cat.FindByTitle("Тетрис");
if (notFound != null) Console.WriteLine($"Найдено: {notFound.Title}");
else Console.WriteLine("Тетрис не найден (null).");

Console.WriteLine($"Игр до удаления: {cat.Count}");
cat.RemoveGame("Portal 2");
Console.WriteLine($"Игр после удаления: {cat.Count}");

Console.WriteLine($"Игр с рейтингом 8+: {cat.CountHighRated(8)}");

Console.WriteLine("\n=== Игровая сессия ===");

Game sessionGame = new Game("Геншин Импакт", "RPG", 2020);
GameSession session = new GameSession(1);

Console.WriteLine($"Начало сессии: {session.TryStart(sessionGame)}");
Console.WriteLine($"Повторное начало: {session.TryStart(sessionGame)}");

Console.WriteLine($"Завершение (сыграно 3 часа): {session.TryFinish(3)}");
Console.WriteLine($"Часы у игры: {sessionGame.PlayTime}");

Console.WriteLine($"Повторное завершение: {session.TryFinish(1)}");
Console.WriteLine($"Часы у игры после повтора: {sessionGame.PlayTime}");