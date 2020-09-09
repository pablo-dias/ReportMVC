namespace ReportMVC2.Models
{


    partial class DataSet1
    {
        public static DataSet1 ObterExemplo()
        {
            var ds = new DataSet1();
            var f1 = ds.Movies.AddMoviesRow(1, "Ratatouille", "Animation", "2007");
            var f2 = ds.Movies.AddMoviesRow(2, "The Butterfly Effect", "Drama", "2004");
            var f3 = ds.Movies.AddMoviesRow(3, "Eternal Sunshine of the Spotless Mind", "Drama", "2004");
            var f4 = ds.Movies.AddMoviesRow(4, "Mr. Nobody", "Drama", "2009");
            var f5 = ds.Movies.AddMoviesRow(5, "Interstellar", "Sci-Fi", "2014");

            return ds;
        }
    }
}
