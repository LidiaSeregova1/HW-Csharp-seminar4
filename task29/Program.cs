
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// Данные вводятся с консоли пользователем

// int[] array = new int [8];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = int.Parse(Console.ReadLine());
    
// }
// Console.WriteLine(string.Join(", ", array));


            Console.WriteLine("Введите восьмизначное число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[8];

            for (int i = 0; i < 8; i++)
            {
                array[i] = new Random().Next(number+1);
                Console.Write(array[i] + "; ");
            }
            Console.WriteLine();
