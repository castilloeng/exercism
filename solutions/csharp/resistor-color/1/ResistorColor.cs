public static class ResistorColor
{

    public enum ColorsType
    {
        black,
        brown,
        red,
        orange,
        yellow,
        green,
        blue,
        violet,
        grey,
        white
    }
    
    public static int ColorCode(string color) => (int)Enum.Parse<ColorsType>(color);
    

    public static string[] Colors()
    {
        return Enum.GetNames<ColorsType>();
    }
}