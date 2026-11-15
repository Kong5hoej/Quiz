using System.Drawing;

Random r = new Random();

int r1 = 0;
int r2 = 0;
int r3 = 0;

int ans = 0;

int number = 0;

int point = 0;

bool inputCheck = true;

string question = " ";

for (int x = 1; x <= 10; x++)
{
    r1 = r.Next(1, 11);
    r2 = r.Next(3);
    r3 = r.Next(1, 11);

    ans = getAnswer(r1, r2, r3);
    question = getQuestion(r1, r2, r3);

    Console.WriteLine(question);

    while (inputCheck == true)
    {
        string input = Console.ReadLine();
        if (int.TryParse(input, out int i))
        {
            inputCheck = false;
            number = Convert.ToInt32(input);

        }
        else
        {
            Console.Clear();
            Console.WriteLine(question);
        }
    }

    Console.Clear();

    if (ans == number)
    {
        point++;
        Console.WriteLine("Correct");
    }
    else
    {
        Console.WriteLine("Wrong");
    }

    Console.WriteLine($"You now have {point} points");

    inputCheck = true;
}

Console.Clear();
Console.WriteLine($"The quiz is finished\nYou got {point} points");

int getAnswer(int a, int b, int c)
{
    if (b == 0)
    {
        return a + c;

    }
    else if (b == 1)
    {
        return a - c;
    }
    else
    {
        return a * c;
    }
}

string getQuestion(int a, int b, int c)
{
    if (b == 0)
    {
        return question = $"What is {r1} + {r3}";

    }
    else if (b == 1)
    {
        return question = $"What is {r1} - {r3}";
    }
    else
    {
        return question = $"What is {r1} * {r3}";
    }
}