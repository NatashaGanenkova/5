int[]array =GetArray(5);
Console.WriteLine(String.Join(" ",array));
Console.WriteLine(Getcount(array));
int[] GetArray(int size)
{
    int[]array=new int[size];
    for(int i=0;i<array.Length;i++){
    array[i]=new Random().Next(100,1000);
    }
return array;
}    
int Getcount (int[]array){
    int rezult=0;
    for(int j=0;j<array.Length;j++){
        if((array[j]%2)==0){
        rezult++;
        }
        }
        return rezult;

}