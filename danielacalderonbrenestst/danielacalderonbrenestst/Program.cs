using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace danielacalderonbrenestst
{


					
    public class Program
	{

		public static string WordSplit(string[] strArr)
		{

			string diccionario = strArr[1];  //dictionary 

			string Firstword = strArr[0];  //first word in array
			string result = ",";

			char c = ',';    //split by ,	
			String[] values = diccionario.Split(c);  //split values 
			string[] acertadas = new string[199];  // words contein

			List<string> list_contein_words = new List<string>();
			Console.Write("---array--");
			Console.Write("\n");

			for (int i = 0; i < strArr.Length; i++)  //read array
			{
				Console.Write("{0}  ", strArr[i]);
			}
			Console.Write("\n");


			for (int i = 0; i < values.Length; i++)
			{
				string palabras = (values[i]);  // insert in array words with match

				if (Firstword.Contains(palabras) == true)
				{  //if is true add in list of strings

					list_contein_words.Add(palabras);
				}
			}





			int x = list_contein_words.Count(); //lenght of list

			for (int r = 0; r < x; r++)
			{

				var word1 = list_contein_words.ElementAt(r);   //select item by item , compare with next item in list 

				for (int ir = 0; ir < x; ir++)
				{

					var word2 = list_contein_words.ElementAt(ir);

					string d = word1 + word2;   //concatenate both words


					if (d.Equals(Firstword))
					{   //if concatenation is equals first word , show msg

						Console.WriteLine(word1 + "," + word2);

						result = word1 + "," + word2;
					}
					else if (!d.Equals(Firstword))
					{

						result = "";

					}

				}
			}

			return result;

		}

		public static void Main()
		{


			string[] strArr = {"hellocat",
   "apple,bat,cat,goodbye,hello,yellow,why"};
			Console.WriteLine(WordSplit(strArr));

		}
	}




}

