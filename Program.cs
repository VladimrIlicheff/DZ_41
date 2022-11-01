/*Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.WriteLine("Введите числа через запятую");
string str = Console.ReadLine();
string[] arr = str.Split(",");
int[] numArray = new int[arr.Length];
for (int i = 0; i < numArray.Length; i++) 
    numArray[i] = int.Parse(arr[i]);
int numValues(int[] arr)
{
    int quan = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] > 0)
            quan++;
    return quan;
}
int quantity = numValues(numArray);
Console.WriteLine($"всего чисел больше 0  --> {quantity}");








