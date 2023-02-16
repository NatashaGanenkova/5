Console.Write("Введите длину массива :");
int num=int.Parse(Console.ReadLine());
int[]array = GetBinArray(num);
Console.WriteLine(String.Join(" ",array));
Console.Write($"[{CountOfEven(array)}]");

int[]GetBinArray(int size)
{
      int[]result =new int[size];
      for(int i=0;i<size;i++){
      result[i]=new Random().Next(1,24);
     }
      return result;
}
int CountOfEven(int[]array){
    int sum = 0;
    for(int i=0;i<array.Length;i++)
    {
        if(i%2==1){
        sum=sum+array[i];}
       
        

    }    

         return sum;
}
       