using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_5_avanzada
{
    public class Tareas
    {
        public static List<Tareas> tareas = new List<Tareas>();
        public int NumTarea {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Estado { get; set; }

        public Tareas(int numTarea,string name, string description, string estado)
        {
            NumTarea = numTarea;
            Name = name;
            Description = description;
            Estado = estado;
        }
        public static void AddTarea()
        {
            Console.Clear();

            string text = "BIENVENIDO AL APARTADO DE AGREGAR TAREA";

            int windowWidth = Console.WindowWidth;

            int spaces = (windowWidth - text.Length) / 2;

            if (spaces < 0)
            {
                spaces = 0;
            }
            string centeredText = new string(' ', spaces) + text;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n{centeredText}");
            Console.ResetColor();
            Console.WriteLine("INGESE EL NÚMERO DE TAREA");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE EL NOMBRE DE LA TAREA");
            string nameHomework = Console.ReadLine();
            Console.WriteLine("INGRESE LA DESCRIPCIÓN DE LA TAREA");
            string description = Console.ReadLine();
            Tareas addTarea = tareas.Find(p => p.Name == nameHomework);
            if (addTarea == null)
            {
                string estadoInicial = "Pendiente";
                tareas.Add(new Tareas(num,nameHomework, description,estadoInicial));
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("LA TAREA SE AGREGO CORRECTAMENTE");
                Console.ResetColor();
                Console.ReadKey();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("LA TAREA YA FUE INGRESADA");
                Console.ResetColor();
                Console.ReadKey();
            }
        }
        public static void ShowTareas()
        {
            foreach (Tareas tarea in tareas)
            {
                Console.Clear();

                string text = "LAS TAREAS INGRESADAS AL MOMENTO SON :";

                int windowWidth = Console.WindowWidth;

                int spaces = (windowWidth - text.Length) / 2;

                if (spaces < 0)
                {
                    spaces = 0;
                }
                string centeredText = new string(' ', spaces) + text;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\n{centeredText}");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($" Número : {tarea.NumTarea}|| Nombre: {tarea.Name} || Descripción : {tarea.Description} || Estado : {tarea.Estado}");
                Console.ResetColor();
                Console.ReadKey();
            }
            
        }
        public static void ChangeEstado()
        {
            Console.Clear();

            string text = "GRACIAS POR TERMINAR TU TAREA ERES UN CRACK:";

            int windowWidth = Console.WindowWidth;

            int spaces = (windowWidth - text.Length) / 2;

            if (spaces < 0)
            {
                spaces = 0;
            }
            string centeredText = new string(' ', spaces) + text;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n{centeredText}");
            Console.ResetColor();
            Console.WriteLine("INGRESE EL NÚMERO DE LA TAREA QUE TERMINO");
            int numTare = int.Parse(Console.ReadLine());
            Tareas deleteTarea = tareas.Find(p => p.NumTarea == numTare);
            if (deleteTarea != null)
            {
                deleteTarea.Estado = "Completada";

            }

        }
    }
}
