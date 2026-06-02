public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        string acronimo = "";
        // Filtrar palabras vacías
string[] words = phrase.Replace("_", " ").Split(new[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);
        foreach(string word in words)
            acronimo += word[0];

        return acronimo.ToUpper();
    }

   
}