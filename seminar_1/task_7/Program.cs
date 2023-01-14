// Программа, выводящая последнюю цифру трехзначного числа

Console.WriteLine("Программа, выводящая последнюю цифру трехзначного числа");
System.Console.WriteLine();

int hundered_number = 0;

do {
    System.Console.Write("Введите целое трехзначное число:\t");
}
while (!Int32.TryParse(
    System.Console.ReadLine(), out hundered_number)
    || (100 > hundered_number) 
    || (hundered_number > 999));

System.Console.WriteLine(hundered_number % 10);