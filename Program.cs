var name = "Ewa";
var age = 20;
//bool isMan = true;  //k - kobieta; m - mężczyzna
var sex = "k";  //k - kobieta; m - mężczyzna

if ( name == "Ewa" && age == 30 )
{
    Console.WriteLine("Ewa, lat 30");
}
else if ( sex == "k" && age < 30 )
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if ( sex == "m" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("nic!");
}