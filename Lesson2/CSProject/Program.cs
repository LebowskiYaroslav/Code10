namespace CSProject;
using System;

class CSProject
{
    static void Main(String[] args)
    {
    // А
    int[] array = new int[5];
    // А2
    string[] array_str = {"bebebe", "babba", "Mbappe"};
    // Б
    int[] array_int = {1, 2, 3, 4, 5};
    Console.Writeline(array_int[1]);
    array_int[2] = 100;
    Console.Writeline(array_int[2]);
    Console.Writeline(array_int.Length);
    //С
    float[] array_float = new float[4];
    //с2
    int[] array_3 = {1, 2, 3};
    //с3
    string[] array_3_str = new string[5];
    array_3_str[0] = 'qwerty0';
    array_3_str[1] = 'qwerty1';
    array_3_str[2] = 'qwerty2';
    array_3_str[3] = 'qwerty3';
    array_3_str[4] = 'qwerty4';
    }
}