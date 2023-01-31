/*

*/

void FillArray(int[] numbers, int leftRange, int rightRange)
{
    Random rnd = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rnd.Next(leftRange, rightRange + 1);
    }
}

void PrintArray(int[] numbers)
{
    System.Console.WriteLine("[ " + string.Join(", ", numbers) + " ]");
}

void ReverseArray(int[] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        temp = arr[i];
        arr[i] =arr[arr.Length - i - 1]; 
        arr[arr.Length - i - 1] = temp;
    }
}


int[] numbers = new int[10];
FillArray(numbers, 0, 10);
PrintArray(numbers);
ReverseArray(numbers);
PrintArray(numbers);