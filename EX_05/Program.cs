// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
// You may assume that each input would have exactly one solution, and you may not use the same element twice.
//You can return the answer in any order.

//Example 1:

// Input: nums = [2,7,11,15], target = 9
// Output: [0,1]
// Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

// Example 2:

// Input: nums = [3,2,4], target = 6
// Output: [1,2]

// Example 3:

// Input: nums = [3,3], target = 6
// Output: [0,1]

int[] MakeArray(int len)
{
    int[] array = new int[len];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    return array;
}

int[] FindElement(int[] array, int element)
{
    int[] arr = new int[2];
    for(int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length; j++)
        {
            if (j != i && array[i] + array[j] == element)
            {
                if (i < j)
                {
                    arr[0] = i;
                    arr[1] = j;
                }
                else
                {
                    arr[0] = j;
                    arr[1] = i;
                }
            }
        }
    }
    return arr;
}

void PrintResult(int[] array, int num)
{
    if (array[0] == array[1])
    {
        Console.WriteLine($"В данном массиве нет двух элементов сумма которых была бы равна {num}");
    }
    else
    {
        Console.WriteLine($"Элементы сумма которых равна {num} находятся на позициях [{array[0]} {array[1]}]");
    }
}

Console.Write("Введите число ");
int num = int.Parse(Console.ReadLine());

int[] array = MakeArray(5);
Console.WriteLine("["+$"{String.Join(", ", array)}"+"]");
int[] arr = FindElement(array, num);
// Console.WriteLine("["+$"{String.Join(", ", arr)}"+"]");
PrintResult(arr, num);