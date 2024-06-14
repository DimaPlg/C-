namespace bank.DataModifMethDb
{
    public static  class chekInputYesNo
    {
        public static string chekYesNo(string input, string[] keywords) 
        {
            string result = "";
            bool check = false;

            foreach (string i in keywords)
            {
                if (i == input.ToLower())
                {
                    result = input.ToLower();
                    check = true;
                    break;
                }
                else
                    check = false;
            }

            while(!check)
            {
                Console.WriteLine("Rewrite, please, regardless of the case: ");
                result = Console.ReadLine();
                foreach (string j in keywords)
                {
                    if (j == result.ToLower())
                    {
                        result = result.ToLower();
                        check = true;
                        break;
                    }
                    else
                       check = false;
                }
            }
            return result;
        }
    }
}
