namespace Delegates
{
    public class StringFunctions
    {
        public static string testString = "Hello How You Doing?";
        public static string testString2 = "Hello How You Doing?";
        public static void StringClone()
        {
            var myStr = testString.Clone();
            System.Console.WriteLine(myStr);
        }
        public static void StringComparer()
        {
            System.Console.WriteLine(string.Compare(testString,testString2));
        }
         public static void StringContact()
        {
            System.Console.WriteLine(string.Concat(testString,testString2));
        }

    }
}