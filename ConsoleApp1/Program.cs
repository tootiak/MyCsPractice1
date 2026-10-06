Console.WriteLine("Hi!");
await Task.Delay(1000);
//pressing a key to start
Console.Write("Press a ");
Console.ForegroundColor=ConsoleColor.DarkRed;
Console.Write("Key");
Console.ResetColor();
Console.WriteLine("...");
Console.ReadKey(true);
//first beep
Console.Beep(3000,100);
await Task.Delay(1000);
Console.Beep(2000,100);
Console.Beep(1000,400);
await  Task.Delay(1000);
Console.WriteLine("Oh Manners!");
await  Task.Delay(1000);
//my name
Console.Write("I'm ");
Console.ForegroundColor=ConsoleColor.Green;
//beep with name
Console.Beep(2000,200);
Console.Beep(1600,200);
Console.WriteLine("Tootia!");
Console.ResetColor();
await Task.Delay(1500);
//my age
Console.Write("I'm ");
Console.ForegroundColor=ConsoleColor.DarkBlue;
Console.Write("19. ");
Console.ResetColor();
await Task.Delay(1000);
//my birth month
Console.Write("I'll be ");
Console.ForegroundColor=ConsoleColor.DarkBlue;
Console.Write("20 ");
Console.ResetColor();
Console.WriteLine("in may.");
await Task.Delay(1000);
//education
Console.Write("I study in ");
Console.ForegroundColor=ConsoleColor.DarkYellow;
Console.WriteLine("university.");
Console.ResetColor();
//art
await Task.Delay(1000);
Console.Write("I love painting. ");
await Task.Delay(700);
Console.WriteLine("Any kind of it.");
await Task.Delay(900);
Console.WriteLine("painting with: ");
await Task.Delay(1000);
Console.ForegroundColor=ConsoleColor.DarkMagenta;
Console.Beep(2000,500);
Console.WriteLine("Color Pencil!");
await Task.Delay(1000);
Console.Beep(1000,500);
Console.WriteLine("Oil color!");
await Task.Delay(1000);
Console.ResetColor();
Console.Beep(3000,500);
Console.Write("And sometimes with just a ");
Console.ForegroundColor=ConsoleColor.DarkMagenta;
Console.WriteLine("Dark pencil!");
Console.ResetColor();
