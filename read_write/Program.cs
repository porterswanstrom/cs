using System;
using System.IO;

int check = 0;
string file = "C:/tmp/io.txt";

StreamWriter writer = File.CreateText(file);
for(int i = 1; i <= 50; i++)
{
	writer.WriteLine(i);
}
writer.Close();

StreamReader reader = File.OpenText(file);
string line = reader.ReadLine();
while(line != null)
{
	if(check % 5 == 0)
		Console.Read();
	Console.WriteLine(line);
	line = reader.ReadLine();
	check++;
}
reader.Close();
File.Delete(file);
