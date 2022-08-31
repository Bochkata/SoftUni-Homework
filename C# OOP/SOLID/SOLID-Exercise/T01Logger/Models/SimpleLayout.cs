
namespace T01Logger
{
    public class SimpleLayout : ILayout
    {
        public string Format => "{0} - {1} - {2}";

        //public SimpleLayout()
        //{
        //    string.Format(Format, "", "", "", "", "");
        //}

    }
}
