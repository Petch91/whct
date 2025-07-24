int jour = DateTime.Today.Day;
int month = DateTime.Today.Month;
int sum = month + jour;
int result = sum * 100;

result -= sum;

Console.WriteLine("UNI3" + result);