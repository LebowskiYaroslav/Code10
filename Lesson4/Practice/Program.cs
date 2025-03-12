namespace CSProject;
using System;

class CSProject
{
    static void Main(String[] args)
    {
        // ПРАКТИКА А-Б
        //1
        /*static int add(int a, int b){
            return a + b;
        }*/
        //2
        /*static int is_even(int number){
            return number % 2 == 0
        }*/
        //3
        /*static string reverse_string(string s){
            char[] charArray = s.ToCharArray();
            string reversed = new string(Array.Reverse(charArray));
            return reversed;
        }*/
        //4
        /*static void find_max(String[] arr){
            return array.Max();
        }*/
        //5
        /*static int factorial(int sallary){
            return sallary * 12;
        }*/
        //6
        /*static int celsius_to_fahrenheit(int celsius){
            return celsius * 9/5 + 32;
        }*/
        //7
        /*static string count_vowels(string s){
            int counter = 0;
            foreach(char c in s){
                if(c =="а" || c == "е" || c == "ё" || c == "о" || c == "у"|| c == "ы"|| c == "и"|| c == "э"|| c == "ю"|| c == "я"){
                    counter += 1;
                }
            }
            return counter;

        }*/
        //8
        /*static int generate_password(string passtohack){
            int count = 0;
            for(int x = 0; x < 10; x++){
                for(int y = 0; y < 10; y++){
                    for(int z = 0; z < 10; z++){
                        for(int h = 0; h < 10; h++){
                        count += 1;
                        string generatedpass = str(x) + str(y) + str(z) + str(h);
                        if(generatedpass  == passtohack){
                            Console.Writeline("Ура! Вы взломали пароль теперь вы хакер");
                            return count;
                        }
            }      
            }
            }
            }

        }*/
        // ПРАКТИКА С ПРАКТИКА С ПРАКТИКА С ПРАКТИКА С ПРАКТИКА С ПРАКТИКА С ПРАКТИКА С ПРАКТИКА С ПРАКТИКА С ПРАКТИКА С ПРАКТИКА С ПРАКТИКА С ПРАКТИКА С
        //Факториал числа
        /*static int Factorial(int n)
        {
            if (n == 1) return 1; 
            return n * Factorial(n - 1); 
        }
        Console.WriteLine(Factorial(5));*/
        //Числа Фибоначчи
        /*static int Fibonachi2(int n){
            int result = 0;
            int b = 1;
            int tmp;
            for (int i = 0; i < n; i++)
            {
                tmp = result;
                result = b;
                b += tmp;
            }
            return result;
        }
        Console.WriteLine(Fibonachi2(10));*/
        //Обращение строки
        /*static string strobr(string str){
            string stringArray = str.Split(delimiter);
            int Length = str.Length;
            string[] reverse_str = new string[Length];
            foreach(char c in str){
                for(int i = 0; i < Length; i++){
                    reverse_str[i] = c;
                }
            }
            Array.Reverse(reverse_str);
            return reverse_str;
            
        }*/
        //Сумма элементов массива
        /*static int summ(int[] a){
            int Length = a.Length;
            int counter = 0;
            for(int i = 0; i < Length; i++){
                counter = counter + a[i];
            }
            return counter;
        }
        int[] a = {1, 2, 3, 4, 5};
        Console.WriteLine(summ(a));*/
        //Наибольший общий делитель (НОД)
        /*static int nod(int a, int b){
            if(b == 0){
                return a;
            }
            else{
                return nod(b, a % b);
            }
        }
        int a = 16;
        int b = 8;
        Console.WriteLine(nod(a, b));*/
        //Проверка палиндрома
        /*static string pal(string b){
            string a = b;
            string spl = a.Split('');
            string[] reverse = Array.reverse(spl);
            if(spl == reverse){
                return "Строка палиндром";
            }
            else{
                return "Строка не палиндром";
            }
        }
        string b = "ротор";
        Console.WriteLine(pal(b));*/

    }
}