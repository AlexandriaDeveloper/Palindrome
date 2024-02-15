public class Program()
{
    public static void Main()
    {
        string[] arryEx1 = ["eye", "california", "12321", "level", "was it a cat i saw"];
        string[] arryEx2 = ["Dubai", "amman", "Cairo", "fes"];
        string[] arryEx3 = null;


        var result = CheckArray(arryEx1);

        if (result != string.Empty)
            Console.WriteLine(result);
        else
            Console.WriteLine("No Word Found Match Criteria");

    }

    private static string CheckArray(string[] arry)
    {
        string result = string.Empty;
        if (arry == null)
            return result;
        foreach (string input in arry)
        {
            if (FindPalindrome(input) > 0)
            {
                if (input.Length > result.Length)
                {
                    result = input;
                }
            }


        }
        return result;
    }
    private static int FindPalindrome(string input)
    {
        var chrs = input.Replace(" ", "").ToLower().ToCharArray();
        int middle = chrs.Length / 2;
        for (int i = 0; i < middle; i++)
        {
            if (chrs[i] != chrs[chrs.Length - 1 - i])
            {
                return -1;
            }
        }

        return chrs.Length;

    }
}