#region 1 - Declaraçoes

using Tarefa1_segunda;
using static System.Runtime.InteropServices.JavaScript.JSType;

string stringInicial = "ABCPTX";
bool testeString = true;

if(stringInicial.Contains("PTX"))
{
    testeString = true;
}
else
{
    testeString = false;
}

Console.WriteLine($"{stringInicial} contem PTX = {testeString}");

#endregion

#region 2 - Propriedades e Metodos extensivos

Console.WriteLine($"indice de PTX em {stringInicial}  = {stringInicial.IndexOf("PTX")}");

string auxiliar = "";
List<string> lista = new List<string>();
for (int i = 0; i < stringInicial.Length; i++)
{
    if (i == stringInicial.IndexOf("PTX"))
    {
        lista.Add(auxiliar);
        auxiliar = "";
    }
    auxiliar = auxiliar + stringInicial[i];
}
lista.Add(auxiliar);
Console.WriteLine("Lista de strings:");
foreach (var item in lista)
{
    Console.WriteLine(item);
}

#endregion

#region 3 - Listas e operações

Console.WriteLine("Lista de strings em ordem alfabetica:");
lista = lista.OrderBy(x => x).ToList();
foreach (var item in lista)
{
    Console.WriteLine(item);
}

List<string> lista3 = new List<string>();

lista3 = lista.Where(x => !x.Contains("B")).ToList();
Console.WriteLine("Lista de strings que nao contem B:");
foreach (var item in lista3)
{
    Console.WriteLine(item);
}

#endregion

#region 4 - Tipos

string numeroString = "10";
int numeroInt = 0;

if (int.TryParse(numeroString, out numeroInt))
{
    Console.WriteLine($"Int convertido usando TryParse: {numeroInt}");
}
else
{
    Console.WriteLine("Conversao invalida");
}
decimal numeroDecimal = 0;
float numeroFloat = 0;
double numeroDouble = 0;

if (decimal.TryParse(numeroString, out numeroDecimal))
{
    Console.WriteLine($"Decimal convertido usando TryParse: {numeroDecimal}");
}
else
{
    Console.WriteLine("Conversao invalida");
}

if (float.TryParse(numeroString, out numeroFloat))
{
    Console.WriteLine($"Float convertido usando TryParse: {numeroFloat}");
}
else
{
    Console.WriteLine("Conversao invalida usando TryParse");
}

if (double.TryParse(numeroString, out numeroDouble))
{
    Console.WriteLine($"Decimal convertido usando TryParse: {numeroDouble}");
}
else
{
    Console.WriteLine("Conversao invalida usando TryParse");
}

decimal numeroDecimal2 = 3.14M;
float numeroFloat2 = 3.14F;
double numeroDouble2 = 3.14;

#endregion

#region 6 - Metodos

var extensaoConversores = new ExtensaoConversores();
int novaInt = extensaoConversores.ConverterStringInt(numeroString);
Console.WriteLine($"Valora a ser convertido: {numeroString}");
Console.WriteLine($"Int convertido usando metodo: {novaInt}");
numeroString = "3,14";
double novaDouble = extensaoConversores.ConverterStringDouble(numeroString);
float novaFloat = extensaoConversores.ConverterStringFloat(numeroString);
decimal novaDecimal = extensaoConversores.ConverterStringDecimal(numeroString);
Console.WriteLine($"Valora a ser convertido: {numeroString}");
Console.WriteLine($"Double convertido usando metodo: {novaDouble}");
Console.WriteLine($"Float convertido usando metodo: {novaFloat}");
Console.WriteLine($"Decimal convertido usando metodo: {novaDecimal}");

#endregion

#region 7 - Tipos de Loops e Listas

var listaNumeros = new List<Numeros>()
{
    new Numeros { NumeroInt = 1, NumeroDecimal = 1.11M, NumeroDouble = 1.12, NumeroFloat = 1.13F },
    new Numeros { NumeroInt = 2, NumeroDecimal = 2.21M, NumeroDouble = 2.22, NumeroFloat = 2.23F },
    new Numeros { NumeroInt = 3, NumeroDecimal = 3.31M, NumeroDouble = 3.32, NumeroFloat = 3.33F },
    new Numeros { NumeroInt = 4, NumeroDecimal = 4.41M, NumeroDouble = 4.42, NumeroFloat = 4.43F },
    new Numeros { NumeroInt = 5, NumeroDecimal = 5.51M, NumeroDouble = 5.52, NumeroFloat = 5.53F }
};


listaNumeros.Add(new Numeros { NumeroInt = 6, NumeroDecimal = 6.61M, NumeroDouble = 6.62, NumeroFloat = 6.63F });
Console.WriteLine("usando o foreach para listar:");
foreach (var item in listaNumeros)
{
    Console.WriteLine($"Int: {item.NumeroInt}, Decimal: {item.NumeroDecimal}, Double: {item.NumeroDouble}, Float: {item.NumeroFloat}");
}
Console.WriteLine("usando o for para listar:");
for(int i = 0; i < listaNumeros.Count; i++)
{
    Console.WriteLine($"Int: {listaNumeros[i].NumeroInt}, Decimal: {listaNumeros[i].NumeroDecimal}, Double: {listaNumeros[i].NumeroDouble}, Float: {listaNumeros[i].NumeroFloat}");
}
int j = 0;
Console.WriteLine("usando o while para listar:");
while (j < listaNumeros.Count){
    Console.WriteLine($"Int: {listaNumeros[j].NumeroInt}, Decimal: {listaNumeros[j].NumeroDecimal}, Double: {listaNumeros[j].NumeroDouble}, Float: {listaNumeros[j].NumeroFloat}");
    j++;
}
#endregion

#region 8

var novaClasse = new NovaClasse("Leonardo", 20, "Vagabundo");
novaClasse.ExibirInformacoes();

#endregion

#region 9
TiposEnum tipo = TiposEnum.Tipo3;
switch (tipo)
{
    case TiposEnum.Tipo1:
        Console.WriteLine($"{TiposEnum.Tipo1} selecionado.");
        break;
    case TiposEnum.Tipo2:
        Console.WriteLine($"{TiposEnum.Tipo2} selecionado.");
        break;
    case TiposEnum.Tipo3:
        Console.WriteLine($"{TiposEnum.Tipo3} selecionado.");
        break;
    default:
        Console.WriteLine("Tipo padrão selecionado.");
        break;
}

#endregion