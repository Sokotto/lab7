List<Film> films = new List<Film>();

Console.WriteLine("Введите количество фильмов:");
int count = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    Film film = new Film();

    Console.Write($"Название {i + 1}-го фильма: ");
    film.Title = Console.ReadLine();

    Console.Write($"Дата и время начала сеанса ({i + 1}-го фильма) (формат dd.MM.yyyy HH:mm): ");
    film.StartTime = DateTime.Parse(Console.ReadLine());

    Console.Write($"Продолжительность сеанса ({i + 1}-го фильма) (в минутах): ");
    film.Duration = TimeSpan.FromMinutes(Convert.ToDouble(Console.ReadLine()));

    Console.Write($"Жанр {i + 1}-го фильма: ");
    film.Genre = Console.ReadLine();

    Console.Write($"Бюджет {i + 1}-го фильма: ");
    film.Budget = Convert.ToDecimal(Console.ReadLine());

    films.Add(film);
}
var filteredFilms = films.FindAll(f => f.StartTime.TimeOfDay > new TimeSpan(18, 0, 0) && f.Duration.TotalMinutes > 100);

if (filteredFilms.Count == 0)
{
    Console.WriteLine("Нет подходящих фильмов.");
}
else
{
    foreach (var film in filteredFilms)
    {
        Console.WriteLine($"\nНазвание: {film.Title}");
        Console.WriteLine($"Дата и время сеанса: {film.StartTime:dd.MM.yyyy HH:mm}");
        Console.WriteLine($"Продолжительность сеанса: {film.Duration.TotalMinutes} минут");
        Console.WriteLine($"Жанр: {film.Genre}");
        Console.WriteLine($"Бюджет: {film.Budget:C}");
    }
}
public class Film
{
    public string Title { get; set; }
    public DateTime StartTime { get; set; }
    public TimeSpan Duration { get; set; }
    public string Genre { get; set; }
    public decimal Budget { get; set; }
}