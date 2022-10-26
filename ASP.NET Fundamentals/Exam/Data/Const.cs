namespace Library.Data
{
    public class Const
    {
        public class ApplicationUser
        {
            public const int NameApplicationUserMinLength = 5;
            public const int PasswordApplicationUserMinLength = 5;
            public const int EmailApplicationUserMinLength = 10;

            public const int NameApplicationUserMaxLength = 20;
            public const int EmailApplicationUserMaxLength = 60;         
            public const int PasswordApplicationUserMaxLength = 20;
        }

        public class Book
        {
            public const int TitleBookMinLength = 10;
            public const int AuthorBookMinLength = 5;
            public const int DescriptionBookMinLength = 5;
            public const string RatingBookMinRate = "0.00";

            public const int TitleBookMaxLength = 50;
            public const int AuthorBookMaxLength = 50;
            public const int DescriptionBookMaxLength = 5000;
            public const string RatingBookMaxRate = "10.00";
        }

        public class Category
        {
            public const int NameCategoryMinLength = 5;
            public const int NameCategoryMaxLength = 50;
        }
    }
}
