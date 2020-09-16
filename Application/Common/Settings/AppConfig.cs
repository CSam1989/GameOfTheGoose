namespace Application.Common.Settings
{
    public class AppConfig
    {
        public Spaces Spaces { get; set; }
    }

    public class Spaces
    {
        public int[] GoozeSpaces { get; set; }
        public SpecialSpace[] SpecialSpaces { get; set; }
    }

    public class SpecialSpace
    {
        public int Space { get; set; }
        public string Name { get; set; }
    }
}