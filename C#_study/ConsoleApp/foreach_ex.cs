using System;

public class foreach_ex
{
		static public void Main(String[] args)
        {
			string[] array = new string[] { "AB", "CD", "EF" };

			//foreach loop 
			foreach(String s in array)
            {
				Console.WriteLine(s);
            }
        }

}
