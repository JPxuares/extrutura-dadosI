using System.Collections;
using System.ComponentModel;

//Criar HashTable
Hashtable openWith = new Hashtable();

try
{
openWith.Add("txt","notepad.exe");
openWith.Add("bmp","paint.exe");
openWith.Add("dib","paint.exe");
openWith.Add("rtf","wordpad.exe");
openWith.Add("txt","notepad++.exe");
}

/*catch(ArgumentException aex)
{
    Console.WriteLine("Opss. Você tentou adicionar uma chave invalida.");
    Console.WriteLine($"Detalhes:{aex.Message}");
}*/
catch(Exception ex)
{
   Console.WriteLine("Erro Genérico");
   //throw ex;
}

// Acessando o conteudo a tabela hash
Console.WriteLine("Na \\ chave = \"rtf\" é {0}", openWith["rtf"]);

//alterando o conteudo da tabela Hash
openWith["rtf"] = "winword.exe";
Console.WriteLine(
    "Na \\ chave = \"rtf\" é {0}"
    , openWith["rtf"]
);

//testar se a chave existe

if(openWith.ContainsKey("ht"))
{
    openWith.Add("ht" , "hypertrm.exe");
    Console.WriteLine("chave ht adicionada.");
}

//percorendo hash com foreach
Console.WriteLine();
foreach(DictionaryEntry de in openWith)
{
    Console.WriteLine(
      "Key = {0} - Value = {1}"
      , de.Key
      , de.Value  
    );
}

//Obtendo apenas os valores do hash 
ICollection valueCol = openWith.Values;
Console.WriteLine();
foreach(string s in valueCol)
{
    Console.WriteLine("value = {0}", s);
}

//Obtendo apenas as chaves do hash 
ICollection KeyCol = openWith.Values;
Console.WriteLine();
foreach(string s in KeyCol)
{
    Console.WriteLine("Key = {0}", s);
}

// Remover registro do hash
Console.WriteLine("removendo (\"doc\")");
openWith.Remove("doc");
if(!openWith.ContainsKey("doc"))
{
    Console.WriteLine(
        "Chave \"doc\" foi removida."
    );
}
Console.WriteLine("Programa em execução");