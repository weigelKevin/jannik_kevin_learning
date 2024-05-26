namespace bruteforce;

class Program
{
    static void Main(string[] args)
    {
        string password = "99";

        string character = "abcdefghijklmnopqrstuvwxyz123456789";

        for (int length = 1; length <= password.Length; length++)
        {
            if (BruteForce(password,character,length,""))
            {
                Console.WriteLine(password);
                break;
            }
        }

        static bool BruteForce(string password, string character, int length, string attempt)
        {
            if (attempt.Length == length)
            {
                if (attempt == password)
                {
                    return true;
                }

                return false;

            }

            foreach (char c in character)
            {
                if (BruteForce(password, character, length, attempt + c))
                {
                    return true;
                }
            }

            return false;
        }
            
        
    }
}