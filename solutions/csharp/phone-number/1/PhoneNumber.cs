using System.Text.RegularExpressions;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        var phoneClean = Regex.Replace(phoneNumber, @"[^0-9]", "");

        if (phoneClean.StartsWith("1") && phoneClean.Length == 11)
            phoneClean = phoneClean[1..];

        if (phoneClean.Length != 10)
            throw new ArgumentException();

        if (phoneClean[0] < '2' || phoneClean[3] < '2')
            throw new ArgumentException();

        return phoneClean;
    }
}