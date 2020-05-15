using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text.RegularExpressions;
using System.Text;


public class Remover
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;
            int result = x << y;
            Console.WriteLine(result);
            
        }

           
        

    }
}

#region MaxProfit
        //    int[] stock_prices = { 7,1,5,3,6,4 };
        //    Console.WriteLine(Max_profit(stock_prices));
        //}
        //public static int Max_profit(int[] arr1)
        //{
        //    int z = 0;
        //    int valley = arr1.Min();
            
        //    int profit = 0;
        //    for (int i = 0; i < arr1.Length; i++)
        //    {
        //        if (valley== arr1[i])
        //        {
        //            z=i;
        //            break;
        //        }  
        //    }
        //    for (int i = z; i <arr1.Length; i++)
        //    {
        //        if (arr1[i]-valley>profit)
        //        {
        //            profit = arr1[i] - valley;
        //        }
        //    }
        //    return profit;
       
        //}
#endregion
#region CompressData
//public static void  Compress(char[] chars)
//{
//    StringBuilder str = new StringBuilder();
//    int head = 0;
//    int next = 1;
//    int count = 1;
//    if (chars.Length==1)
//    {
//        str.Append(0); 
//    }
//    while (next!=chars.Length)
//    {

//        if (chars[head] == chars[next])
//        {
//            count++;
//            next++;
//        }
//        else if (chars[head] != chars[next])
//        {

//            str.Append(chars[head].ToString());
//            if (count!=1)
//            {
//                str.Append(count.ToString());
//            }
//            head = next;
//            next++;
//            count = 1;
//        }
//    }

//    str.Append(chars[head].ToString());
//    if (count!=1)
//    {
//        str.Append(count.ToString());
//    }
//    str.ToString().ToCharArray();
//    Console.WriteLine( str.ToString());

//}
#endregion
#region Ispalindrome

//    Console.WriteLine(IsPalindrome("a."));
//}

//public static bool IsPalindrome(string s)

//{
//   var z = s.ToLower().Where(char.IsLetterOrDigit).ToList();

//    int x = 0;
//    int y = z.Count - 1;
//    if (x==y)
//    {
//        return true;
//    }
//   while(true)
//    {
//        if (x>y)
//        {
//            return true;
//        }
//        if (z[x]!=z[y])
//        {
//            return false;
//        }
//        x++;
//        y--;

//    }

#endregion
#region FirstuniquChar
//{ Console.WriteLine(FirstUniqChar("ddddcbbba"));
//}

//public static int FirstUniqChar(string s)
//{
//    int z=0;
//    int count=0; 
//    Dictionary<char,int> hashtable = new Dictionary<char, int>();
//    for (int i = 0; i < s.Length; i++)
//    {
//        int currentcount;
//        if (hashtable.ContainsKey(s[i]))
//        {
//            hashtable.TryGetValue(s[i], out currentcount);
//            hashtable[s[i]] = currentcount + 1;
//        }
//        else
//        {
//            count = 0;
//            hashtable.Add(s[i], count);
//        }
//    }
//    for (int i = 0; i < s.Length; i++)
//    {
//        int value;
//        hashtable.TryGetValue(s[i], out value);
//        if (value==0)
//        {
//            return i;
//        }
//    }
//    return -1;
//}
#endregion
#region Move Zeroes
//    int[] nums =
//    {
//        0,1,0,3,12
//    };
//    MoveZeroes(nums);
//}
//public static void MoveZeroes(int[] nums)
//{
//    int x = 0;
//    int y = nums.Length - 1;
//    int temp;
//    while (x<y)
//    {
//        if (nums[x] == 0)
//        {

//            temp = nums[x];
//            nums[x] = nums[y];
//            nums[y] = temp;
//            x++;
//            y--;
//        }
//        else
//        {
//            x++;
//        }

//    }
//    foreach (var item in nums)
//    {
//        Console.WriteLine(item);
//    }
//}

#endregion
#region plusOne
/*int[] digits = { 1, 2, 3, 4 };
            foreach (var item in PlusOne(digits))
            {
                Console.WriteLine(item);
            }
        }
            public static int[] PlusOne(int[] digits)
{

    List<int> a = new List<int>();
    int x = 0;
    for (int i = 0; i < digits.Length; i++)
    {
        x += digits[i] * Convert.ToInt32(Math.Pow(10, digits.Length - i - 1));

    }

    int z = x + 1;



    return a.ToArray();
}
*/

#endregion
#region Intersect
/* int[] nums1 = {1,2,2,1};
           int[] nums2 = {2,2};
            foreach (var item in Intersect(nums1,nums2))
            {
                Console.WriteLine(item);
            }
        }
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            int x = 0;
            int y = 0;
            int z = 0;
            List<int> nums3 = new List<int>();
            Array.Sort(nums1);
            Array.Sort(nums2);

            while (x < nums1.Length && y < nums2.Length)
            {
                if (nums1[x] == nums2[y])
                {
                    nums3.Add(nums2[y]);
                    x++;
                    y++;
                    z++;
                }
                else if (nums1[x] < nums2[y])
                {
                    x++;
                }
                else if (nums1[x] > nums2[y])
                {
                    y++;
                }
            }
            return nums3.ToArray();


        } */
#endregion
#region single number
/*int[] nums =
       {
           4,1,2,1,2,4
       };
       foreach (int item in SingleNumber(nums))
       {
           Console.WriteLine(item);
       }
   }
   public static int[] SingleNumber(int[] nums)
   {
       int[] vs1 = { 0 };
       int x = 0;
       HashSet<int> vs = new HashSet<int>();
       for (int i = 0; i < nums.Length; i++)
       {

           if (vs.Contains(nums[i]))
           {
               vs.Remove(nums[i]);
           }
           else
           {
               vs.Add(nums[i]);
           }


       }
       if (vs.Count==0)
       {
           return vs1;
       }

       return vs.ToArray();
   }



}*/

#endregion
#region Countvalley

//static int countingValleys(int n, string s)
//{
//    int count = 0;
//    int sum = 0;
//    for (int i = 0; i < s.Length; i++)
//    {
//        if (s[i] == 'U')
//        {
//            if (++sum == 0)
//            {
//                count++;
//            }
//        }
//        else
//        {
//            --sum;
//        }

//    }
//    return count;

//}
#endregion
#region ConvertTime
//string s = "07:05:45PM ";
//string result = timeConversion(s);
//Console.WriteLine(result);

//    string s1 = "12:40:22AM";
//string result1 = timeConversion(s1);
//Console.WriteLine(result1);

//    string s2 = "12:45:54PM";
//string result2 = timeConversion(s2);
//Console.WriteLine(result2);

////07:05:45PM
////19:05:45
//static string timeConversion(string s)
//{
//    string z = s.Substring(0, 2);
//    string y = s.Substring(8, 2);
//    string x = s.Substring(3, 5);
//    string result = string.Empty;
//    if(y=="PM")
//    {
//        int add;
//        if (z == "12")
//        {
//            add = 12;

//        }
//        else
//        {
//            int inz = Convert.ToInt32(z);
//            add = inz + 12;
//        }

//        string add1 = add.ToString();
//        result = add1 +":"+ x;

//    }
//    else if (y=="AM")
//    {
//        if(z=="12")
//        {
//            z = "00";
//        }
//        result = z +":"+ x;
//    }

//    return result;


//}
#endregion
#region Birthdaycake

//    int[] ar = { 1, 3, 3, 2, 4,4,4 };
//    int z =birthdayCakeCandles(ar);
//    Console.WriteLine(z);
//}
//static int birthdayCakeCandles(int[] ar)
//{
//    int max = ar.Max();
//    int count = 0;
//    for (int i = 0; i < ar.Length; i++)
//    {
//        if (max == ar[i])
//        {
//            count++;
//        }
//    }
//    return count;


//}
#endregion
#region min Max

//    int[] arr = { 256741038, 623958417, 467905213, 714532089, 938071625 };
//    miniMaxSum(arr);

//}
//static void miniMaxSum(int[] arr)
//{

//    //Int64 x = 0;
//    //Int64 y = 0;

//    //for (int i = 0; i < arr.Length; i++)
//    //{
//    //    Int64 z = Convert.ToInt64(arr.Sum());
//    //    Int64 e = Convert.ToInt64(arr[i]);
//    //    Int64[] total = { z - e };
//    //    x = total.Max();
//    //    y = total.Min();
//    //}
//    Int64 x = arr.Sum() - arr.Min();
//    Int64 y = arr.Sum() - arr.Max();

//    Console.WriteLine("{0} {1}", y, x);
//}
#endregion
#region staircase
//static void staircase(int n)
//{
//    for (int i = 0; i < n; i++)
//        Console.WriteLine(new String('#', i + 1)/*.PadLeft(n, ' ')*/);

//}
#endregion
#region plusminus
//static void plusMinus(int[] arr)
//{
//    double positive = 0;
//    double negative = 0;
//    double zero = 0;

//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] > 0)
//        {
//            positive++;
//        }
//        else if (arr[i] == 0)
//        {
//            zero++;
//        }
//        else
//        {
//            negative++;
//        }
//    }
//    double total = arr.Length;
//    double inpo = positive / total;
//    double inne = negative / total;
//    double inze = zero / total;
//    Console.WriteLine(inpo);
//    Console.WriteLine(inne);
//    Console.WriteLine(inze);

//}
#endregion
#region Maxmum Toys
//    int[] prices = { 22,23,22};
//    int z = maximumToys(prices, 7);
//    Console.WriteLine(z);

//static int maximumToys(int[] prices, int k)
//{
//    int count=0;
//    List<int> price = prices.ToList();
//    price.Sort();
//    for (int i = 0; i < price.Count; i++)
//    {
//        if (price[i]<k)
//        {
//            k -= price[i];
//            count++;

//        }

//    }
//    return count;

//}

#endregion
#region Rotateleft
//int[] a = { 1, 2, 3, 4, 5 };
//         int[] b = rotLeft(a, 2);
//         foreach (int z in b)
//         {
//             Console.WriteLine(z);
//         }
//     static int[] rotLeft(int[] a, int shiftnumber)
//     {
//         int[] newarray = new int[a.Length] ;
//         for (int index = 0; index <a.Length; index++)
//         {
//             int shiftindex =(index+ (a.Length-shiftnumber)) % a.Length;
//             newarray[shiftindex]=a[index];

//         }

//         return newarray;
//     }    
#endregion
#region MaxNumber for each row
//        int[,] x = { { 1, 5, 2, 3 }, { 2, 2, 3, 4 }, { 22, 3, 4, 5 } };
//        List<int> e = new List<int>(3);
//            for (int i = 0; i< 4; i++)
//            {
//                for (int j = 0; j< 3; j++)
//                {
//                    e.Add(x[j, i]);
//                }
//    int[] b = e.ToArray();
//    int c = b.Max();

//}
//private static int[] GetARow(int[,] numbers, int row, int dim = 0)
//{
//    int[] outArray = new int[numbers.GetLength(dim)];
//    for (int i = 0; i < numbers.GetLength(dim); i++)
//    {
//        outArray[1] = numbers[row, i];
//    }
//    return outArray;


//}

#endregion
#region SantaClimb
//string direction = " ";
//       Console.WriteLine(SantaClimbStairs(direction));
//       public static int SantaClimbStairs( string input)
//       {
//           int x = 0;
//           int y = 0;
//           int z = 0;
//           char[] stair = input.ToCharArray();
//           for (int i = 0; i < stair.Length; i++)
//           {
//               switch (stair[i])
//               {
//                   case '(':
//                       x++;
//                       break;
//                   case ')':
//                       y++;
//                       break;
//               }
//           }
//           z = x - y;
//           return z; 
//       }
#endregion
#region aVeryBigSum
//long[] ar = { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };
//long s = aVeryBigSum(ar);
//Console.WriteLine(s);
//          static long aVeryBigSum(long[] ar)
//{

//    long s = ar.Sum();
//    return s;

//}

#endregion
#region CompareTriplets
//    // Complete the compareTriplets function below.

//    List<int> a = new List<int> { 17, 28, 30 };
//    List<int> b = new List<int> { 99, 16, 8 };
//    List<int> c = compareTriplets(a, b);
//        foreach (int number in c)
//        {
//            Console.WriteLine(number);
//        }
//static List<int> compareTriplets(List<int> a, List<int> b)
//    {
//        int x = 0;
//        int y = 0;
//        for (int i = 0; i < a.Count ; i++)
//        {



//            if (a[i] > b[i])
//            {
//                x++;
//            }
//            else if (a[i] < b[i])
//            {
//                y++;
//            }
//            else
//            {

//            }



//        }

//        List<int> result = new List<int> { x, y };
//        return result;
//    }
#endregion
#region intial name
//    string x= "Sam Harris";
//    Console.WriteLine(AbbrevName(x));
//public static string AbbrevName(string name)
//{
//    string nam = name.ToUpper();
//    string[] namearray = nam.Split(' ');
//    string x = namearray[0].Substring(0, 1);
//    string y = namearray[1].Substring(0, 1);

//    return string.Join( ".",x,y);
//}
#endregion
#region reverse string
//    string y = "world";
//    string z = Solution(y);
//    Console.WriteLine(z);
//public static string Solution(string str)
//{
//    char[] rev = str.ToCharArray();
//    Array.Reverse(rev);
//    string x = new string(rev);
//    return x;
//}
#endregion
#region Removesmallest
//List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
//RemoveSmallest(numbers);
//foreach (var number in numbers)
//{
//    Console.WriteLine(number);
//}

//Console.WriteLine("-------");

//List<int> number1 = new List<int> { 5, 3, 2, 1, 4 };
//RemoveSmallest(number1);
//foreach (var number in number1)
//{
//    Console.WriteLine(number);
//}

//Console.WriteLine("-------");

//List<int> number2 = new List<int> { 1, 2, 3, 1, 1 };
//RemoveSmallest(number2);
//foreach (var number in number2)
//{
//    Console.WriteLine(number);
//}


//   public static List<int> RemoveSmallest(List<int> numbers)
//{

//   int x=numbers.Min();
//   numbers.Remove(x);
//   return numbers;

//}

#endregion
#region codewars function
//double x = basicOp('+', 4, 7);
//Console.WriteLine(x);


//public static double basicOp(char operation, double value1, double value2)
//{ double result = 0;
//    switch (operation)
//    {
//        case '+':
//            result = value1 + value2;
//            break;

//        case '-':

//            result = value1 - value2;
//            break;

//        case '*':

//            result = value1 * value2;
//            break;

//        case '/':

//            result = value1 / value2;
//            break;
//    }
//    return result;
//}



#endregion
#region count of positive/sum of negative


//    int[] input = new int[] { };
//    int[] result = CountPositivesSumNegatives(input);
//    foreach (int item in result)
//    {
//        Console.WriteLine(item);
//    }

//            public static int[] CountPositivesSumNegatives(int[] input)
//{


//    if (input != null && input.Length > 0)
//    {

//        int[] postive = input.Where(z => z > 0).Distinct().ToArray();
//        int[] negative = input.Where(z => z < 0).ToArray();
//        int postiveresult = postive.Count();
//        int negativeresult = negative.Sum();
//        int[] result = new int[] { postiveresult, negativeresult };
//        return result;

//    }
//    else if (input == null)
//    {
//        return input;

//    }
//    else 
//            {
//        return input;
//    }

//}
#endregion
#region Count odd number
//    int[] seq = { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 };
//    int x =find_it(seq);
//    Console.WriteLine(x);
//}
//public static int find_it(int[] seq)
//{
//    if (seq.Length > 0)
//    {
//        int[] oddnumber = seq.Where(z => z % 2 != 0).Distinct().ToArray();
//        int x = oddnumber.Count();
//        return x;
//    }
//    else
//        return ' ' ;
#endregion
#region Captilized words
//string phrase = "How can mirrors be real if our eyes aren't real";
//string t = ToJadenCase(phrase);
//Console.WriteLine(t);        
//public static string ToJadenCase(this string phrase)
//{
//    string[] x = phrase.Split(' ');
//    for (int i = 0; i < x.Length; i++)
//    {
//        x[i] = x[i].Substring(0, 1).ToUpper() + x[i].Substring(1);
//    }
//    string z = string.Join(" ", x);
//    return z;
//}
#endregion
#region Middlechar
//    string x = "middle";
//    string y = "testing";
//    string z = "test";
//    Console.WriteLine(GetMiddle(x));
//    Console.WriteLine(GetMiddle(y));
//    Console.WriteLine(GetMiddle(z));
//    Console.WriteLine(GetMiddle("A"));
//    public static string GetMiddle(string s)
//{
//    int count = s.Count();


//    if (count==1)
//    {
//        return s;
//    }
//    else if (count%2==0)
//    {
//        int even = count / 2-1;
//        return s.Substring(even, 2);
//    }
//    else 
//    {
//        int odd = (count + 1) / 2-1;
//        return s.Substring(odd, 1);
//    }

//}
#endregion
