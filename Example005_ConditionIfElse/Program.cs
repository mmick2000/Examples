Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();
if (username.ToLower() == "маша"){
    Console.WriteLine("Ура! Это же наша Маша!!!");
}
else {
Console.WriteLine("Привет, " + username + "!!!");
}