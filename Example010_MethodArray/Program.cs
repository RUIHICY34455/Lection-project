﻿int[] array = {1,2,3,4,5,6,7,8};

int n = array.Length;
int find = 7;

int index = 0;
while (index < n)
{
    if(array[index] == find)
    {
        System.Console.WriteLine(index);
        break;
    }
    // index = index + 1;
    index ++;
}