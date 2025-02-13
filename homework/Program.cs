/*/task 1
using System;

class Program
{
    static void Main() {
        Random rand = new Random();
        int randnumber = rand.Next(1, 101);

        Console.WriteLine("try to guess my number:");
        int x = int.Parse(Console.ReadLine());
        while (x != randnumber) {
            if (x > randnumber) {
                Console.WriteLine("oops, your number too high, try again!");
            }
            else{
                Console.WriteLine("oops, your number too low, try again!");
            }
            x = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("yeyy, you guessed it!");
    }
}
*/


/*/#task 2
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        int[] nums = new int[10];
        Random rand = new Random();

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = rand.Next(0, 101);
        }
        foreach (int numbers in nums)
        {
            Console.WriteLine(numbers + " ");
        }
        int max = nums[0];

        for (int j = 1; j < nums.Length; j++)
        {
            if (nums[j] > max)
            {
                max = nums[j];
            }
        }
        Console.WriteLine("max number is:" + max);
    }
    
}
*/


/*/task 3

using System;

class Program
{
    static void Main()
    {
        int[] nums = new int[20];
        Random rand = new Random();

        for(int i = 0; i < nums.Length; i++)
        {
            nums[i] = rand.Next(1, 51);
            Console.Write(nums[i] + " ");
        }
        int even = 0;
        int odd = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0)
            {
                even++;
            }
            else
            {
                odd++;
            }
        }
        Console.WriteLine("even numbers are:" + even + " and odds are:" + odd);
    }
}
*/


/*/task 4


int[] nums = new int[10];
Random rand = new Random();
int sum = 0;
Console.Write("here is array: ");
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = rand.Next(0, 101);
    Console.Write(nums[i] + " ");
    sum += nums[i];
}
Console.WriteLine();

Console.WriteLine("the sum of all numbers in the array is: " + sum);
*/


/*/task 5 

string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
Random rand = new Random();
string password = "";

for (int i = 0; i < 8; i++)
{
    password += chars[rand.Next(chars.Length)];
}

Console.WriteLine("Generated Password: " + password);
*/


/*/task 6 

Random rand = new Random();
int[] nums = new int[15];
int largest = nums[0];

Console.Write("the array:");
for(int i = 0; i < nums.Length; i++)
{
    nums[i] = rand.Next(0, 101);
    Console.Write(nums[i] + " ");
    if (nums[i] > largest)
    {
        largest = nums[i];
    }
}

int smallest = nums[0];
for (int i = 1; i < nums.Length; i++)
{
    if (nums[i] < smallest)
    {
        smallest = nums[i];
    }
}
Console.WriteLine();
Console.WriteLine("the largest number of array is: " + largest + " and the smallest number is: " + smallest);
*/



/*/task 7

Random rand = new Random();
int[] arr = new int[10];

Console.WriteLine("the array in normal order: ");
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(0, 100);
    Console.Write(arr[i] + " ");
}
Console.WriteLine();


for(int i = 0; i < arr.Length / 2; i++)
{
    int temp = arr[i];
    arr[i] = arr[arr.Length - 1 - i];
    arr[arr.Length - 1 - i] = temp;
}

Console.WriteLine("the array in reverse order: ");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}
*/



/*/task 8

string[] words = { "apple", "banana", "cherry", "grape" };
Random rand = new Random();

int index = rand.Next(0, words.Length);

string word = words[index];
Console.WriteLine("try to guess my word!");

string x = Console.ReadLine();

while(x != word)
{
    Console.WriteLine("oops, you didn't guess the word, try again!");
    x = Console.ReadLine();
}

Console.WriteLine("yess, you did it!");
*/



/*/task 9

Random rand = new Random();

for (int i = 1; i < 6; i++)
{
    int roll = rand.Next(1, 7);
    Console.WriteLine("roll " + i + ":" + roll);
}
*/

/*/task 10

Console.WriteLine("enter a number:");
int num = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i + "*" + num + "=" + i * num);
}
*/


/*/task 11

Random rand = new Random();
int sumofpositive = 0;
int sumofnegative = 0;
Console.Write("the array: ");
for (int i = 0; i < 20; i++)
{
    int num = rand.Next(-50, 50);
    Console.Write(num + " ");
    if(num < 0)
    {
        sumofnegative += num;
    }
    else
    {
        sumofpositive += num;
    }
}
Console.WriteLine();
Console.WriteLine("the sum of positive numbers is: " + sumofpositive + "  and the sum of negative numbers is: " + sumofnegative);
*/



/*/task 12


Random rand = new Random();
int[] arr = new int[10];
Console.Write("the array: ");

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(1, 10);
    Console.Write(arr[i] + " ");
}
Console.WriteLine();
Console.Write("dupliacte numbers are: ");

for(int i = 0; i < 10; i++)
{
    bool already = false;

    for(int k = 0; k < i; k++)
    {
        if (arr[i] == arr[k])
        {
            already = true;
            break;
        }
    }
    if (already) continue;

    for (int j = i + 1; j < 10; j++)
    {
        if (arr[i] == arr[j])
        {
            Console.Write(arr[i] + " ");
            break;
        }
    }
}
*/

/*/task 13

string[] subjects = { "The cat", "A dog", "The bird" };
string[] verbs = { "jumps", "runs", "flies" };
string[] objects = { "over the fence", "on the grass", "into the tree" };

Random rand = new Random();

List<string> sentence = new List<string>();
sentence.Add(subjects[rand.Next(subjects.Length)]);
sentence.Add(verbs[rand.Next(verbs.Length)]);
sentence.Add(objects[rand.Next(objects.Length)]);

Console.WriteLine(string.Join(" ", sentence));
*/


/*/task 14

string[] moves = { "rock", "paper", "scissors" };
string mymove = "";
Random rand = new Random();

mymove = moves[rand.Next(moves.Length)];
Console.WriteLine("choose your move in numbers: 1.Rock, 2.Paper, 3. Scissors");
int yourmove = int.Parse(Console.ReadLine());

string yourmovestr = moves[yourmove - 1];

if(mymove == yourmovestr)
{
    Console.WriteLine("draw)");
}
else if ((mymove == "rock" && yourmovestr == "paper") ||
                 (mymove == "paper" && yourmovestr == "scissors") ||
                 (mymove == "scissors" && yourmovestr == "rock")) {
    Console.WriteLine("haha,my move was " + mymove + " and you won!");
}
else
{
    Console.WriteLine("haha,my move was " + mymove + " and I won!");
}
*/