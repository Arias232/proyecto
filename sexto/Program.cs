using System;
using System.IO;

namespace Sentenias

{ 

class SentenciaUsing
{

public static void Main (string[] args)

{

string s;

using (TextWRiter w= File.CreateText("log.txt"))
{

w.WriteLine("linea uno");
2.WriteLine("linea dos");

}
usign (textREader r= File.OpenText("log.txt"));
{

While ((s = r.ReadLine()) != null);
{

Console.WrtieLine( "s");
}
}

}
}
}