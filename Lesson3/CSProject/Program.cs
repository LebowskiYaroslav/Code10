﻿namespace CSProject;
using System;

class CSProject
{
    static void Main(String[] args)
    {
       // нвоый урок практики с Иваном практика 1 сумма элементов массива
        /*int[] numbers = {1, 2, 3, 4, 5};
        int result = 0;
        foreach(int num in numbers){
            result += num;
        }
        Console.WriteLine(result);*/
        // поиск макс элемента 2
        /*int[] numbers = {1, 2, 3, 4, 5};
        Array.Sort(numbers);
        Array.Reverse(numbers);
        Console.WriteLine(numbers[0]);*/
        //практика 3
        /*int[] numbers = {1, 2, 3, 4, 5};
        Array.Reverse(numbers);
        Console.WriteLine(numbers[0]);*/
        // практика 4
        /*int[] numbers = {1, 2, 3, 4, 5};
        foreach(int num in numbers){
            if(num % 2 == 0){
                Console.WriteLine(num);
            }

        }*/
        //практика 5
        // int[] numbers = {-1, -2, 3, -4, 5
        /*};
        foreach(int num in numbers){
            if(num < 0){
                Console.WriteLine(num);
            }
        }*/
        // практика 6
        /*int[] numbers = {10, 20, 30, 40};
        int index = Array.IndexOf(numbers, 30);
        Console.WriteLine(index)*/
        //ПРАКТИКА 7    
        /*int[] numbers = {10, 20, 30, 40, 50, 60, 70};
        for(int i = 0, i < numbers.Length, i++){
            if(i % 2 != 0){
                Console.WriteLine(numbers[i])
            }
        }*/
        // практика 8
        /*int[] numbers = {10, 20, 30, 40, 50, 60, 70};
        int Length = numbers.Length;
        Array.Reverse(numbers);
        Console.WriteLine(numbers[0]);
        Console.WriteLine(numbers[Length]);*/
        //Практика 9
        /*int[] numbers = {9, 5, 2, 7, 4, 3};
        Array.Sort(numbers);
        Console.WriteLine(numbers);*/
        //Практика 10
        /*int[] numbers = {-1, -2, 3, -4, 5};
        foreach(int num in numbers){
            if(num < 0){
                int index = Array.IndexOf(numbers, num);
                numbers[index] = 0;
            }
        }*/
        //практика 11
        
        //практика 12
        /*int[] numbers = {1, 2, 3, 3, 3, 3, 4, 5, 5, 5};
        Array.Sort(numbers);
        int distinct = numbers.Distinct().Count();
        Console.WriteLine(distinct);*/
        //практика 13
        /*int[] numbers = {1, 2, 3, 3, 3, 3, 4, 5,};
        var most = numbers.GroupBy(x => x).OrderByDescending(x => x.Count()).First();
        Console.WriteLine("Наиболее часто встречается {0} в количестве {1}", most.Key, most.Count());*/
        

        //ДОМАШНЯЯ РАБОТА 1
        int[] mass1 = {1, 2, 3, 4, 5};
        int[] mass2 = {6, 7, 8, 9, 10};
        int length1 = mass1.Length;
        int length2 = mass2.Length;
        int[] result = new int[length1 + length2];
        for (int i = 0; i < length1; i++)
        {
            result[i] = mass1[i];
        }
        for (int i = 0; i < length2; i++)
        {
            result[length1 + i] = mass2[i];
        }
        foreach(int num in result){
            Console.WriteLine(num);
        }
        //2
        int[] arr = {1, 2, 3, 4, 5};
        int n = arr.Length;
        int[] result1 = new int[n];
        n -= 1;
        int rotation = 2;
        for(int i = 0; i < rotation; i++){
            result1[i] = arr[(n - 1) + i];
        }
        for(int i = 0; i <= rotation; i++){
            result1[i + rotation] = arr[i];
        }
        foreach(int num in result1){
            Console.WriteLine(num);
        }
        
    }
}