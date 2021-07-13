using System;

namespace DIO.TVShows
{
    class Program
    {
        
        static TvShowRepository repository = new TvShowRepository();
        static MovieRepository repository2 = new MovieRepository();
        static void Main(string[] args)
        
        { 

        string userOption = GettingUserOption();

            while (userOption.ToUpper() != "X")
            {   
                
                switch (userOption)
                {
                    case "1":
                    ListTvShows();
                    break;
                    case "2":
                    AddTvShow();
                    break;
                    case "3":
                    UpdateTvShow();
                    break;
                    case "4":
                    DeleteTvShow();
                    break;
                    case "5":
                    SeeTvShow();
                    break;
                    case "6":
                    ListMovie();
                    break;
                    case "7":
                    AddMovie();
                    break;
                    case "8":
                    UpdateMovie();
                    break;
                    case "9":
                    DeleteMovie();
                    break;
                    case "0":
                    SeeMovie();
                    break;
                    case "C":
                    Console.Clear();
                    break;

                    default:
                    throw new ArgumentOutOfRangeException();
                }
                
                userOption = GettingUserOption();

            }

            Console.WriteLine("Thank you for using our services");
            Console.ReadLine();
        }

        //// TVSHOWS
        ///
        //
        
        private static void ListTvShows()
        {
            Console.WriteLine("List tvshows");

            var  list = repository.List();
            if (list.Count == 0)
            {
                Console.WriteLine("There are no tvshows added");
                return;
            }

            foreach(var tvshow in list)
            {
                var Deleted = tvshow.returnDeleted();
                Console.WriteLine("#ID {0}:  - {1}  {2}", tvshow.returnId(), tvshow.returnTitle(), (Deleted ? "*Deleted*" : "" ));
            }
        }

        private static void AddTvShow()
        {
            Console.WriteLine("Add new tvshow");

            foreach(int i in Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine("{0}:  - {1}",i, Enum.GetName(typeof(Genre), i));
            }
            Console.Write("Type in the wanted genre between the options listed: ");
            int genreEntry = int.Parse(Console.ReadLine());

            Console.Write("Type in the tvshow title: ");
            string titleEntry = Console.ReadLine();

            Console.Write("Type in the tvshow year: ");
            int yearEntry = int.Parse(Console.ReadLine());

            Console.Write("Type in the tvshow synopsis: ");
            string synopsisEntry = Console.ReadLine();

            TVShow newTvshow =  new TVShow(id: repository.NextId(), 
                                            genre: (Genre) genreEntry,
                                            title: titleEntry,
                                            year: yearEntry,
                                            synopsis: synopsisEntry);

            repository.Add(newTvshow);
                                            
        }

        private static void UpdateTvShow()
        {
            Console.WriteLine("Type in the tvshow id: ");
            int tvshowid = int.Parse(Console.ReadLine());
        

            foreach(int i in Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine("{0}:  - {1}",i, Enum.GetName(typeof(Genre), i));
            }
            Console.Write("Type in the wanted genre between the options listed: ");
            int genreEntry = int.Parse(Console.ReadLine());

            Console.Write("Type in the tvshow title: ");
            string titleEntry = Console.ReadLine();

            Console.Write("Type in the tvshow year: ");
            int yearEntry = int.Parse(Console.ReadLine());

            Console.Write("Type in the tvshow synopsis: ");
            string synopsisEntry = Console.ReadLine();

            TVShow UpdateTvShow =  new TVShow (id: tvshowid, 
                                            genre: (Genre) genreEntry,
                                            title: titleEntry,
                                            year: yearEntry,
                                            synopsis: synopsisEntry);

            repository.Update(tvshowid, UpdateTvShow);
                                            
        }
        
        private static void DeleteTvShow()
        {
            Console.WriteLine("Type in the tvshow id: ");
            int tvshowid = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Do you really wish to delete "+ tvshowid + "?" + "  yes or no?");
            string answer = Console.ReadLine();
            if  (answer.Equals ("yes", StringComparison.CurrentCultureIgnoreCase))
            {
                repository.Delete(tvshowid); 
                Console.WriteLine("The tvshow with the id: " + tvshowid + " has been deleted.");
            }
            else
            {
                 Console.WriteLine("As you wish, the tvshow with the ID: " + tvshowid + " will not be deleted.");
                 return;
            }
                                           
        }

        private static void SeeTvShow()
        {
            Console.WriteLine("Type in the tvshow id: ");
            int tvshowid = int.Parse(Console.ReadLine());

            var tvshow = repository.ReturnById(tvshowid);

            Console.WriteLine(tvshow);                                
        }

        //// MOVIES
        ///
        //
        

        private static void ListMovie()
        {
            Console.WriteLine("List movies");

            var  list = repository2.List();
            if (list.Count == 0)
            {
                Console.WriteLine("There are no movies added");
                return;
            }

            foreach(var movie in list)
            {
                var Deleted = movie.returnDeleted();
                Console.WriteLine("#ID {0}:  - {1}  {2}", movie.returnId(), movie.returnTitle(), (Deleted ? "*Deleted*" : "" ));
            }
        }

        private static void AddMovie()
        {
            Console.WriteLine("Add new movie");

            foreach(int i in Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine("{0}:  - {1}",i, Enum.GetName(typeof(Genre), i));
            }
            Console.Write("Type in the wanted genre between the options listed: ");
            int genreEntry = int.Parse(Console.ReadLine());

            Console.Write("Type in the movie title: ");
            string titleEntry = Console.ReadLine();

            Console.Write("Type in the movie year: ");
            int yearEntry = int.Parse(Console.ReadLine());

            Console.Write("Type in the movie synopsis: ");
            string synopsisEntry = Console.ReadLine();

            Movie newMovie =  new Movie(id: repository2.NextId(), 
                                            genre: (Genre) genreEntry,
                                            title: titleEntry,
                                            year: yearEntry,
                                            synopsis: synopsisEntry);

            repository2.Add(newMovie);
                                            
        }

        private static void UpdateMovie()
        {
            Console.WriteLine("Type in the movie id: ");
            int tvshowid = int.Parse(Console.ReadLine());
        

            foreach(int i in Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine("{0}:  - {1}",i, Enum.GetName(typeof(Genre), i));
            }
            Console.Write("Type in the wanted genre between the options listed: ");
            int genreEntry = int.Parse(Console.ReadLine());

            Console.Write("Type in the movie title: ");
            string titleEntry = Console.ReadLine();

            Console.Write("Type in the movie year: ");
            int yearEntry = int.Parse(Console.ReadLine());

            Console.Write("Type in the movie synopsis: ");
            string synopsisEntry = Console.ReadLine();

            Movie updateMovie =  new Movie (id: tvshowid, 
                                            genre: (Genre) genreEntry,
                                            title: titleEntry,
                                            year: yearEntry,
                                            synopsis: synopsisEntry);

            repository2.Update(tvshowid, updateMovie);
                                            
        }
        
        private static void DeleteMovie()
        {
            Console.WriteLine("Type in the movie id: ");
            int movieid = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Do you really wish to delete "+ movieid  + "?" + "  yes or no?");
            string answer = Console.ReadLine();
            if  (answer.Equals ("yes", StringComparison.CurrentCultureIgnoreCase))
            {
                repository2.Delete(movieid ); 
                Console.WriteLine("The movie with the id: " + movieid  + " has been deleted.");
            }
            else
            {
                 Console.WriteLine("As you wish, the movie with the ID: " + movieid  + " will not be deleted.");
                 return;
            }
                                           
        }
        private static void SeeMovie()
        {
            Console.WriteLine("Type in the movie id: ");
            int movieid = int.Parse(Console.ReadLine());

            var movie = repository2.ReturnById(movieid);

            Console.WriteLine(movie);                                
        }

        ////
        ///
        //
        
        private static string GettingUserOption()
        {   
            Console.WriteLine();
            Console.WriteLine("Welcome to DIO TvShows and Movies!");
            Console.WriteLine("Please, write down below the chosen option: Tvshows or Movies?");
            Console.WriteLine();
            
            string option = Console.ReadLine();
                if  (option.Equals ("Tvshows", StringComparison.CurrentCultureIgnoreCase))      
                {
                
                    Console.WriteLine("Please select between the options below:");
                    Console.WriteLine("1 - List tvshows");
                    Console.WriteLine("2 - Add a new tvshow");
                    Console.WriteLine("3 - Update tvshows");
                    Console.WriteLine("4 - Delete tvshow");
                    Console.WriteLine("5 - See tvshow");
                    Console.WriteLine("C - Clear screen");
                    Console.WriteLine("X - Exit");
                    Console.WriteLine();

                    string userOption = Console.ReadLine().ToUpper();
                    Console.WriteLine();
                    return userOption; 

                }

                else if (option.Equals ("movies", StringComparison.CurrentCultureIgnoreCase))
                {   
                    Console.WriteLine("Please select between the options below:");
                    Console.WriteLine("6 - List movies");
                    Console.WriteLine("7 - Add a new movie");
                    Console.WriteLine("8 - Update movies");
                    Console.WriteLine("9 - Delete movie");
                    Console.WriteLine("0 - See movie");
                    Console.WriteLine("C - Clear screen");
                    Console.WriteLine("X - Exit");
                    Console.WriteLine();

                    string userOption = Console.ReadLine().ToUpper();
                    Console.WriteLine();
                    return userOption;
                }

                else 
                {
                    throw new ArgumentOutOfRangeException();
                }
                
        }
             
    }
}
