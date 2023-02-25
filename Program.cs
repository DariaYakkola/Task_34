int[] GetArray(int size, int minValue, int maxValue)
{
  int[] result = new int[size];
  for (int i = 0; i < size; i++)
  {
    result[i] = new Random().Next(minValue, maxValue + 1);
  }
  return result;
}
int[] array = GetArray(10, 100, 999);
int count = 0;
int size = array.Length;
for (int i = 0; i < size ; i++)
{
  if (array[i] % 2 == 0 )
  {
    count += 1;
  }
}
Console.WriteLine($"Количество четных числе в массиве [ {String.Join(" ", array)} ] равно {count} ");