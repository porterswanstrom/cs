using System;
using System.IO;

string file = "C:/tmp/io.txt";

StreamWriter writer = File.CreateText(file);
for(int i=1; i<=50; i++)
{
	writer.WriteLine(i);
}
writer.Close();

StreamReader reader = File.OpenText(file);
string line = reader.ReadLine();
for(int  i=0; line != null; i++, line = reader.ReadLine())
{
	if(i % 5 == 0)
		Console.Read();
	Console.WriteLine(line);
}
reader.Close();
File.Delete(file);