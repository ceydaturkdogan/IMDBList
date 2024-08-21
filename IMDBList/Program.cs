using IMDBList;

bool situation = true;
List<Film> FilmList = new List<Film>();
double minValue = 4.0;
double maxValue = 9.0;
while (situation)
{

List: Console.WriteLine("What is the name of the movie you want to add?");
    string name = Console.ReadLine();
    Console.WriteLine("What is the score of the movie you want to add?");
    double imdb = Convert.ToDouble(Console.ReadLine());
    Film film=new Film(name, imdb);
    FilmList.Add(film);
    Console.WriteLine("Do you want to add new film?(y/n)");
    string answer = Console.ReadLine();


    if (answer == "y")
    {

        goto List;

    }
    else
    {
        Console.WriteLine("All Movie List");
        foreach (var films in FilmList)
        {
            Console.WriteLine(films.FilmName);
        }

        Console.WriteLine("Movies with Between 4.0-9.0 IMDB Score");
        var filteredFilms=FilmList.Where(f=> f.ImdbScore>=minValue && f.ImdbScore<=maxValue).ToList();

        foreach (var films in filteredFilms)
        {
            Console.WriteLine($"{films.FilmName} IMDB score:{films.ImdbScore}");
        }

        Console.WriteLine("Movies starts with 'a'");
        var filmsContaina = FilmList.Where(f => f.FilmName.StartsWith("A", StringComparison.OrdinalIgnoreCase)).ToList();
        foreach (var films in filmsContaina)
        {
            Console.WriteLine($"{films.FilmName} - IMDb Puanı: {films.ImdbScore}");
        }
        situation = false;
    }
}

