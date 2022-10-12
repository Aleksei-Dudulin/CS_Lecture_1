Console.WriteLine ("Введите имя пользователя");
string username = Console.ReadLine();

if (username.ToLower() == "Алекс")
{
    Console.WriteLine("Ура, наконец-то Алекс на месте");
}
else
{
    Console.Write("Ну здарова, ");
    Console.WriteLine(username);
}
