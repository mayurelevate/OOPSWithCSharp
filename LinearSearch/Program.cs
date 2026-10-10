// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");

int index_position =  LinearSearch();
Console.WriteLine($"Index POsition of 3 is {index_position}");
Console.ReadLine();

static int LinearSearch()
{

    int[] numArrya = { 1,10,90,6, 2, 3, 4, };
    //Find X=3 number position
    int index = 0;

    Array.Sort(numArrya);


    for(int i =0; numArrya.Length-1 > i; i++)
    {
        if(numArrya[i] == 5)
        {
            index = i;
            break;
        }
        else
        {
            index = -1;
        }
    }



    return index;
}



