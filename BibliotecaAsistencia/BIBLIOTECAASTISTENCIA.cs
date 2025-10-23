using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaAsistencia
{
    public class BIBLIOTECAASTISTENCIA
    {
        public void Registroasistencia()   //B_A.
        {
            int curso;
            int opcion;
            int asistio = 0;
            int falto = 0;
            int tarde = 0;
            int contador = 0;

            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("Seleccione el curso para registrar asistencia:");
            Console.WriteLine("[1] Ms. Excel");
            Console.WriteLine("[2] Ms. Access");
            Console.WriteLine("[3] Ms. Word");
            Console.WriteLine("[4] Ms. PowerPoint");
            Console.WriteLine("[5] Ms. Autocad");
            Console.WriteLine("[6] Ms. Diseño Gráfico");
            Console.WriteLine("==============================================");

            do
            {
                Console.Write("Ingrese el número del curso: ");
                curso = int.Parse(Console.ReadLine());
                if (curso < 1 || curso > 6)
                {
                    Console.WriteLine("Curso no válido, inténtelo de nuevo.");
                }
            } while (curso < 1 || curso > 6);

            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("Curso seleccionado: " + curso);
            Console.WriteLine("==============================================");
            Console.WriteLine("Se tomará lista (máximo 15 estudiantes)");
            Console.WriteLine();

            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese asistencia del estudiante:");
                Console.WriteLine("[1] Asistió");
                Console.WriteLine("[2] Faltó");
                Console.WriteLine("[3] Tarde");
                Console.Write("Opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        asistio = asistio + 1;
                        break;
                    case 2:
                        falto = falto + 1;
                        break;
                    case 3:
                        tarde = tarde + 1;
                        break;
                    default:
                        Console.WriteLine("Opción no válida, intente de nuevo.");
                        continue;
                }

                contador = contador + 1;

                if (contador < 15)
                {
                    Console.Write("¿Desea registrar otro estudiante? (s/n): ");
                    string respuesta = Console.ReadLine().ToLower();
                    if (respuesta != "s")
                    {
                        break;
                    }
                }

            } while (contador < 15);

            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("RESUMEN DE ASISTENCIA DEL CURSO " + curso);
            Console.WriteLine("==============================================");
            Console.WriteLine("Total de estudiantes: " + contador);
            Console.WriteLine("Asistieron: " + asistio);
            Console.WriteLine("Faltaron: " + falto);
            Console.WriteLine("Llegaron tarde: " + tarde);
            Console.WriteLine("==============================================");

            Console.WriteLine("Presione cualquier tecla para salir");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
