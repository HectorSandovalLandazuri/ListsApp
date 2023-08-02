

List<string> firstNames = new List<string>();
firstNames.Add("Héctor");
firstNames.Add("Claudia");
firstNames.Add("Manuel");
Console.WriteLine($"El segundo elemento es {firstNames[1]}");
Console.WriteLine($"El último elemento es {firstNames[firstNames.Count-1]}");
firstNames.Remove("Claudia");
Console.WriteLine($"El segundo elemento es {firstNames[1]}");
firstNames[1] = firstNames[1].ToUpper();
Console.WriteLine($"El segundo elemento es {firstNames[1]}");


List<string> students = new List<string>();
string agregar;
do
{
	Console.Write("¿Desea agregar alumno? S/N ");
	agregar = Console.ReadLine();
	if (agregar.ToLower() =="s")
	{
		Console.Write("Nombre del alumno: ");
		students.Add(Console.ReadLine());
	}
} while (agregar.ToLower() == "s");

Console.WriteLine($"Hay {students.Count()} alumnos.");



