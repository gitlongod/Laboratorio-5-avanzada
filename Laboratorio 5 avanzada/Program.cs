using Laboratorio_5_avanzada;
bool generalContinue = true;
do
{
	try
	{
		ShowMenu(ref Tareas.tareas);
	}
	catch (Exception)
	{

		throw;
	}
} while (true);

int Menu()
{
	Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("BIENVENIDO A FREETAREAS");
    Console.WriteLine("INGRESA UNA OPCIÓN DE 1-4");
    Console.ResetColor();
	Console.ForegroundColor= ConsoleColor.Magenta;
    Console.WriteLine("1.Añadir Tarea");
    Console.WriteLine("2.Ver todas las Tareas");
	Console.WriteLine("3.Marcar tarea como Completada");
    Console.WriteLine("4.Salir");
	int option = int.Parse(Console.ReadLine());
	return option;

}
void ShowMenu(ref List<Tareas>tareas)
{
	switch (Menu())
	{
		case 1:
			Tareas.AddTarea();
			break;
			case 2:
			Tareas.ShowTareas();
			break;
			case 3:
			Tareas.ChangeEstado();
			break;
			case 4:
			generalContinue = false;
			break;
			
	}
}
