Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "maks")
{
    Console.WriteLine("Ура, это же МАКС!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}