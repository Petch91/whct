int jour = DateTime.Today.Day;
int month = DateTime.Today.Month;
int sum = month + jour;
int result = sum * 100;

result -= sum;
result += 3;

Console.WriteLine("UNI" + result);

Console.WriteLine();
Console.WriteLine("Appuyez sur une touche pour quitter");
Console.ReadKey();