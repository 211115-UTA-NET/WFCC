// Exercise 1 – Fizz Buzz 
// Complete the function below so that it takes 4 integer parameters(start, end, divisor1, and divisor2) 
// and when invoked loops from the start value to the end value inclusive and for each number in that range adds to a 
// list a value based on the following set of rules: 

// 1) If the value is evenly divisible by divisor1 then add "Fizz" =3
// 2) If the value is evenly divisible by divisor2 then add "Buzz" =5
// "Bang" = 7
// 3) If the value is evenly divisible by both divisor1 and divisor2 then add "FizzBuzz" 
// 4) If the value is not evenly divisible by either divisor then add the value itself. 



// List<string> result = FizzBuzz(10, 15, 3, 5);
// foreach(string item in result)
// {
//     Console.WriteLine(item);
// }
List<string> FizzBuzz(int start, int end, int d1, int d2)
{
    List<string> Out = new List<string>();

    for( int i = start; i<= end; i++)
    {
        string sub = "";
        if((i%d1==0)||(i%d2==0))
        {
            if (i%d1==0)
            {
                sub += "Fizz";
            }
            if (i%d2==0)
            {
                sub += "Buzz";
            }
        }
        else
        {
            sub += $"{i}";
        }

        Out.Add(sub);
    }
    return Out;
}

// Exercise 2 – Word Count 
// Complete the function below so that it will take a string of text as input and return an object the keys of which 
// will be the distinct words from the text and the value will be the count of the number of times that word was 
// encountered in the text. Your function should be case insensitive so that, for example, "dog" and "Dog" would be 
// treated as the same word. The resulting object keys should all be in lowercase. 

// So if you invoke this function: 
// WordCount("Four score and seven years ago the score was tied four to four in inning number seven") 
// Then returns the list.



//Exercise 3 – String Shuffle 
//Complete the function below so that it takes three string parameters(str1, str2, and str3) and returns a boolean 
//indicating if the final string parameter is a valid shuffle of the first two. A valid shuffle is one where the third 
//string can be formed by interleaving the characters of the first two while maintaining the left to right ordering of 
//the characters from each. 

//If you invoke this function: 
//IsValidShuffle("abc", "def", "dabecf") the expected response is true ------ dabfec
//If you invoke this function: 
//IsValidShuffle("abc", "def", "bdacef") the expected response is false 




//Console.WriteLine(IsValidShuffle("abchi", "defg", "dabecfgih"));
bool IsValidShuffle(string str1, string str2, string str3)
{
    bool test = true;

    foreach( char letter in str3)
    {
        if(str1 == "")
        {
            if(letter == str2[0])
            {
                str2 = str2.Remove(0, 1);
            }
            else
            {
                test = false;
            }           
        }
        else if(str2 == "")
        {
            if(letter == str1[0])
            {
                str1 = str1.Remove(0, 1);
            }
            else
            {
                test = false;
            }           
        }
        else if(letter == str1[0])
            {
                str1 = str1.Remove(0, 1);
            }
        else if(letter == str2[0])
        {
            str2 = str2.Remove(0, 1);
        }
        else
        {
            test = false;
        }
    }

    return test;
}