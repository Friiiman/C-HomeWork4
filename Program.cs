void Task1(){

    /*
    Напишите цикл, который принимает на вход два числа (A и B) 
    и возводит число A в натуральную степень B.
    */

    Console.Write("Введите число A: ");
    int numberA = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите число B: ");
    int numberB = Convert.ToInt32(Console.ReadLine());

    double result = Math.Pow(numberA, numberB);

    Console.WriteLine($"Число {numberA} в {numberB} степени равно {result}");

}

void Task2(){

    // Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    number = Math.Abs(number);
    int result = 0;

    while(number > 0){
        result = result + number % 10;
        number /= 10;
    }

    Console.WriteLine($"Сумма цифр в числе равна {result}");

}

void Task3(){

    /*
    Напишите программу, которая задаёт массив из 8 элементов и 
    выводит отсортированный по модулю массив.
    */

    Random random = new Random();
    int size = 8;
    int[] array = new int[size];

    Console.Write("Данный массив: ");

    for(int i = 0; i < array.Length; i++){
        array[i] = random.Next(-100, 100);

        Console.Write($"{array[i]}, ");
    }

    Console.Write("\b\b.");
    Console.WriteLine();
    Console.Write("Отсортированный по модулю массив: ");

    for(int i = 0; i < array.Length; i++){
        int minPosition = i;

        for(int j = i; j < array.Length; j++){
            if(Math.Abs(array[j]) < Math.Abs(array[minPosition])){
                minPosition = j;
            }
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;

        Console.Write($"{array[i]}, ");

    }

    Console.Write("\b\b.");

}

Task1();
// Task2();
// Task3();
