// This is comment to my code

//rakendus küsib kasutajalt sisestada tema nime
//rakendus tervitab kasutajat nimepidi

Console.WriteLine("Enter your name:"); //output
//string - sõne
string userName = Console.ReadLine(); //input

Console.WriteLine("Hello" + ", " + userName + "!"); //output

//stringinterpolation
Console.WriteLine($"Hello, {userName}!"); //output