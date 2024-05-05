using _5by5_Idade_Em_Bissextos;

string name, job;
int age;
Console.WriteLine("Write your name: ");
name = Console.ReadLine();
Console.WriteLine("Write your job: ");
job = Console.ReadLine();
Console.WriteLine("Write your age: ");
age = int.Parse(Console.ReadLine());

Pessoa pessoa = new Pessoa(name, age,job);
pessoa.LeapYears();
pessoa.Print();