
Console.Write("Введите номер четверти: ");
int? quarter = int.Parse(Console.ReadLine());

switch (quarter)
{
    case 1:
        {
            System.Console.WriteLine("В первой четверти X>0, Y>0");
            break;
        }
    case 2:
        { System.Console.WriteLine("В второй четверти X<0, Y>0"); break; }
    case 3:
        {
            System.Console.WriteLine("В третьей четверти X<0, Y<0");
            break;
        }
    case 4:
        { System.Console.WriteLine("В четвертой четверти X>0, Y<0"); break; }
    default:
        {
            System.Console.WriteLine("Такой четверти не существует");
            break;
        }
}