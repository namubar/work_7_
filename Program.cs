Console.Write("Введите ряд чисел (для разделения используйте пробел или запятую): ");       
int[] arr = Array.ConvertAll(Console.ReadLine()!.Split(',',' '), int.Parse);            //В качестве разделителя чисел выбраны пробелы или запятые
                                                                                        //другие тоже возможны, нужно указать в качестве аргументов в методе .Split()
int countArr (int[]arr)
{
int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)                         
    {
        count++;
    }
}
return count;
}
int count = countArr( arr);
Console.WriteLine($"Положительных чисел: {count}");