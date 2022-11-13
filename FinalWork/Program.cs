Console.WriteLine();
Console.WriteLine("FinalWork\n");
//  Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//  длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
//   либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//  лучше обойтись исключительно массивами.

void Zadacha()
{
    Console.WriteLine($"Заданный массив: ");
    string[] attempt =
        {"12",
        "abc",
        "345",
        "defgh",
        "6789",
        "101",
        "ijk"};
    foreach (var arr in attempt)
        Console.WriteLine(arr);

    string[] decision = new string[attempt.Length];
    int startSize = 0;
    Console.WriteLine($"Новый массив: ");
    foreach (var newArr in attempt)
    {
        if (newArr.Length <= 3)
        {
            decision[startSize] = newArr;
            startSize++;
        }
    }
    Console.WriteLine(string.Join(Environment.NewLine, decision, 0, startSize));
   }
Zadacha();


