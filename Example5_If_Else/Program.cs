Console.WriteLine ("Введите имя пользователя");
string username = Console.ReadLine();

if (username.ToLower() == "хуй")
{
    Console.WriteLine("Ура, наконец-то Хуй на месте");
}
else
{
    Console.Write("Ну здарова, ");
    Console.WriteLine(username);
}