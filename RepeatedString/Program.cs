//int[] numbers = { 1, 2, 3, 1, 2, 4, 5, 10, 11, 4, 5,10,11 }; 

//var result = Enumerable.Range(0, numbers.Length - 1)
//    .Select(i => new { First = numbers[i], Second = numbers[i + 1] })
//    .GroupBy(p => new { p.First, p.Second })
//    .Where(g => g.Count() > 1).Select(g => g.Key); 


//foreach (var pair in result) 
//{ Console.WriteLine($"{pair.First} {pair.Second}"); }

// Question : Print the repeated pair of string and print 


int[] numbers = { 1, 2, 3, 1, 2, 4, 5,6,9, 10, 11, 4, 5,6,9 ,1,2};

int length = numbers.Length;


//for (int i = 0; i < length - 1; i++)
//{
//    for (int j = i + 1; j < length - 1; j++)
//    {
//        if (numbers[i] == numbers[j] && numbers[i + 1] == numbers[j + 1])
//        {
//            Console.WriteLine(numbers[i] + " " + numbers[i + 1]);
//            break;
//        }
//    }
//}


for (int i = 0; i < length - 1; i++)
{
    bool isRepeated = false;

    for (int j = i + 1; j < length - 1; j++)
    {
        if (numbers[i] == numbers[j] &&
            numbers[i + 1] == numbers[j + 1])
        {
            isRepeated = true;
            break;
        }
    }

    if (isRepeated)
    {
        bool alreadyprinted = false;

        for (int k = 0; k < i; k++)
        {
            if (numbers[i] == numbers[k] &&
                numbers[i + 1] == numbers[k + 1])
            {
                alreadyprinted = true;
                break;
            }
        }

        if (!alreadyprinted)
        {
            Console.WriteLine($"{numbers[i]} {numbers[i + 1]}");
        }
    }
}

