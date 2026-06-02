public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        int total=0;
        int exp = number.ToString().Length;
        var digits = number.ToString().Select(d => int.Parse(d.ToString()));
        foreach(int digit in digits){
            total += (int)Math.Pow(digit, exp);
        }

        if (number == total)
            return true;

        return false;
    }
}