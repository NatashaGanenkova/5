Console.Write("Введите элементы массива через пробел: ");
string elements = Console.ReadLine();
int[] baseArray = GetArrayFromString(elements);

Console.WriteLine(String.Join(" ", ResultArray(baseArray)));

int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

int ResultArray(int[] array)
{
 int min = int.MaxValue;
 int max = int.MinValue;   
    for (int i = 0; i < array.Length ; i++)
    {
        if (min>array[i]){
            min=array[i];
        }
        if (max<array[i]){
            max=array[i];
        }
    }
   
    return max-min;
}
