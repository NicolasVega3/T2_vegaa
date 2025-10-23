using System;
using BiblioMatriculas;
using BibliotecaAsistencia;

namespace Principal_Vega
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BIBLIOTECAASTISTENCIA B_A = new BIBLIOTECAASTISTENCIA();
            classmatricula B_M = new classmatricula();

            string opc;
            do
            {
                MENU();
                opc = Console.ReadLine().ToUpper();
                switch (opc)
                {
                    case "A":
                        B_M.matempresas();
                        break;
                    case "B":
                        B_M.matpersonas();
                        break;
                    case "C":
                        B_A.Registroasistencia();
                        break;
                    case "D":
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción del menú.");
                        break;
                }

                if (opc != "D")
                {
                    Console.WriteLine("Presione cualquier tecla para continuar... ");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (opc != "D");
        }
        public static void MENU()
        {
            Console.WriteLine("====================================");
            Console.WriteLine("  Sitemas de Matricula y Asistencia");
            Console.WriteLine("====================================");
            Console.WriteLine("[A] - Matricula de empresas ");
            Console.WriteLine("[B] - Matricula de personas ");
            Console.WriteLine("[C] - Registrar asistencia ");
            Console.WriteLine("[D] - Salir del sistema ");
            Console.WriteLine("====================================");
            Console.Write("Seleccione una opción: ");
        }
    }
}
