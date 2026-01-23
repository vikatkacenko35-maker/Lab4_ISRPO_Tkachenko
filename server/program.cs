// See https://aka.ms/new-console-template for more information
System.Console.WriteLine($"Hello!");
void Show_FIO(string FIO)
{
    System.Console.WriteLine(FIO);
}
void Show_Group(string group)
{
    System.Console.WriteLine(group);
}
void Show_data(){
    System.Console.WriteLine(DateTime.Now);
}
System.Console.WriteLine("===МЕНЮ ВЫБОРА ДЕЙСТВИЙ===");
System.Console.WriteLine("1 — Показать ФИО\n2 — Показать группу\n3 — Показать дату\n4 — Выход");
int answer = int.Parse(Console.ReadLine());
switch (answer)
{
    case 1:
        System.Console.WriteLine("Введите ваше ФИО: ");
        Show_FIO(Console.ReadLine()); break;
    case 2:
        System.Console.WriteLine("Введите вашу группу: ");
        Show_Group(Console.ReadLine());break;
    case 3:
        Show_data(); break;
    case 4:
        System.Console.WriteLine("До свидания!"); break;
}