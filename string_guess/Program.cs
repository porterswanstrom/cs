using System;

Random r = new Random();
string s = "";
string keypress = "";

for(int i = 0; i < 6; i++)
{
	Console.Clear();
	for(int j = 0; j <= i; j++)
		//s += r.Next(10);
		s += ((char)r.Next(65, 90));
	Console.Write(s);
	Thread.sleep(2000);
	Console.Clear();
	keypress = Console.ReadLine();
	Console.Clear();
	if(s != keypress) return;
	Console.Write("Success");
	Thread.Sleep(1000);
	s = "";
}
