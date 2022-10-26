namespace Watchlist.Data
{
    public static class DataConstants
    {
        public class UserConstants
        {
            public const int UsernameMaxLength = 20;
            public const int UsernameMinLength = 5;

            public const int EmailMaxLength = 60;
            public const int EmailMinLength = 10;

            public const int PasswordMaxLength = 20;
            public const int PasswordMinLength = 5;

            public const string InvalidUserId = "Invalid User Id";

        }


        public class MovieConstants
        {
            public const int TitleMaxLength = 50;
            public const int TitleMinLength = 10;

            public const int DirectorNameMaxLength = 50;
            public const int DirectorNameMinLength = 5;

            public const string RatingMin = "0.00";
            public const string RatingMax = "10.00";
            public const string RatingDecimal = "decimal(18,2)";

            public const string InvalidMovieMessage = "You have entered invalid or incorrect data!";
            public const string InexistantGenre = "Genre does not exist";
            public const string InvalidMovieId = "Invalid Movie Id";

        }

        public class GenreConstants
        {
            public const int GenreNameMaxLength = 50;
            public const int GenreNameMinLength = 5;
        }

        public class ControllerConstants
        {
            public static string GeneralErrorMessage = "Something went wrong. Please try again!";
        }

    }
}
