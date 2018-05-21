using System.IO;
using System;
/***********************************************************************************************/
//Autor: Pascal Lainé
//Date: 2018-05-21
/***********************************************************************************************/
class Program
{
    static void Main()
    {
		bool result;
		long nCard = 4012888888881881;
		//long nCard = 1274;
		result = validateCard(nCard);
        Console.WriteLine(result);
    }
	
// Validate a credit card number with the Luhn algorithm  	
// Input: Credit card number
// Output: True if the number is valide, False if it is not 
	static bool validateCard (long num)
	{
	    bool valide;
		long total = 0;
		long valuPosBef = 1;
		long valuPosNow = 10;
		long digit = 0;
		long tempNum = num;
		bool multiply = false;
		
		while (tempNum != 0)
		{
			digit = (tempNum % valuPosNow)/valuPosBef;
			tempNum = tempNum - (digit*valuPosBef);
			digit = digit *(Convert.ToInt32(multiply)+1);
			total += (digit%10)+(int)(digit/10);
			valuPosBef = valuPosBef*10;
			valuPosNow = valuPosNow*10;
			multiply = !multiply;
		//	Console.WriteLine("{0} ; {1}",tempNum,total);
		}
		
		if(total%10 == 0)
		{
			valide = true;
		}
		else
		{
			valide = false;
		}
		return valide;
		
	}
}