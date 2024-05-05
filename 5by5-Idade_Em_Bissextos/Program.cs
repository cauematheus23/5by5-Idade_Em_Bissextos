using _5by5_Idade_Em_Bissextos;
Pessoa pessoa = new Pessoa();
Console.WriteLine("Write your name: ");
pessoa.setName(Console.ReadLine());
Console.WriteLine("Write your job: ");
pessoa.setJob(Console.ReadLine());
Console.WriteLine("Write your age: ");
pessoa.setAge(int.Parse(Console.ReadLine()));
Console.WriteLine(pessoa.ToString());