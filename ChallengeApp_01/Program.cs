using ChallengeApp_01;

Employee user1 = new Employee("Grzegorz", "Badura", 45);
Employee user2 = new Employee("Mateusz", "Badura", 15);
Employee user3 = new Employee("Mariusz", "Ostapowicz", 47);

user1.AddScore(10);
user1.AddScore(10);
user1.AddScore(10);
user1.AddScore(10);
user1.AddScore(10);
user1.AddScore(1);
// sum is 51

user2.AddScore(10);
user2.AddScore(10);
user2.AddScore(10);
user2.AddScore(0);
user2.AddScore(0);
user2.AddScore(0);
// sum is 30

user3.AddScore(10);
user3.AddScore(10);
user3.AddScore(0);
user3.AddScore(0);
user3.AddScore(0);
user3.AddScore(0);
// sum is 20

string nameMax = "";
string surnameMax = "";
var resultMax = 0;

Console.WriteLine("Pracownik nr 1 to: " + user1.Name + " " + user1.Surname + ", lat " + user1.Age + ", jego punkty to: " + user1.Result);
Console.WriteLine("Pracownik nr 2 to: " + user2.Name + " " + user2.Surname + ", lat " + user2.Age + ", jego punkty to: " + user2.Result);
Console.WriteLine("Pracownik nr 3 to: " + user3.Name + " " + user3.Surname + ", lat " + user3.Age + ", jego punkty to: " + user3.Result);

if (user1.Result > user2.Result)
{
    resultMax = user1.Result;
    nameMax = user1.Name;
    surnameMax = user1.Surname;
}
else if (user2.Result > user3.Result)
{
    resultMax = user2.Result;
    nameMax = user2.Name;
    surnameMax = user2.Surname;
}
else if (user3.Result > user2.Result)
{
    resultMax = user3.Result;
    nameMax = user3.Name;
    surnameMax = user3.Surname;
}

Console.WriteLine();
Console.WriteLine("Pracownik z największą liczbą punktów to: " + nameMax + " " + surnameMax + ", a jego liczba punktów to: " + resultMax);