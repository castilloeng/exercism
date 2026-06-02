public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {

        if (sliceLength <= 0)
            throw new ArgumentException();

        
        if (sliceLength > numbers.Length)
            throw new ArgumentException();

        var resultado = new List<string>();
        
        for(int index = 0; index < numbers.Length - sliceLength + 1; index ++)
            resultado.Add(numbers[index..(index + sliceLength)]);    

        return resultado.ToArray();
        
    }
}