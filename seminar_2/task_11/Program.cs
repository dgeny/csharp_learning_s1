/**Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98*/

Random rand = new Random(); // Объявление объекта класса Random 
int randNumber = rand.Next(100, 1000); // Генерация переменной от 10 до 99 -- [10; 100) || [10; 99]
// int randNumber2 = new Random().Next(10, 100);
System.Console.WriteLine(randNumber);

int trimmed = randNumber / 100 * 10 + randNumber % 10;
System.Console.WriteLine(trimmed);

