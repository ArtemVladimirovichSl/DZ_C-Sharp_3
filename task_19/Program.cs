Console.Write("Введите число: ");
int arg = Convert.ToInt32(Console.ReadLine());
            
Console.WriteLine(arg == int.Parse(new string(arg.ToString().Reverse().ToArray())));