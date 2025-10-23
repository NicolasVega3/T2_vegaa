using System;
using System.Security.Authentication;

namespace BiblioMatriculas
{
    public class classmatricula
    {
        public void matempresas() //B_M.
        {
            Console.Clear();
            
            double ruc;
            string nomempresa;
            int participantes, curso;
            double costototal=0, preciocurso=0;
            do
            {
                Console.Clear();
                Console.WriteLine("====================================");
                Console.WriteLine("        MATRÍCULA DE EMPRESAS");
                Console.WriteLine("====================================");
                Console.WriteLine("Escribir RUC de la empresa: ");
                ruc = Convert.ToDouble(Console.ReadLine());
                if (!(ruc < 100000000000 && ruc > 999999999))
                {
                    Console.Clear();
                    Console.WriteLine("RUC de la empresa debe tener 11 digitos");
                    Console.WriteLine("Presione cualquier tecla para volver a intentarlo");
                    Console.ReadKey();
                }
                else
                    break;
            } while (true);

            Console.WriteLine("Nombre de la empresa: ");
            nomempresa = Console.ReadLine();
            Console.WriteLine("Cantidad Participantes: ");
            participantes = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.Clear();
                Console.WriteLine("====================================");
                Console.WriteLine("       Curso a matricularse ");
                Console.WriteLine("[1] Ms. Excel");
                Console.WriteLine("[2] Ms. Access");
                Console.WriteLine("[3] Ms. Word");
                Console.WriteLine("[4] Ms. PowerPoint");
                Console.WriteLine("[5] AutoCAD");
                Console.WriteLine("[6] Diseño Grafico");
                Console.WriteLine("====================================");
                Console.WriteLine();
                curso = Convert.ToInt32(Console.ReadLine());
            } while (curso < 1 || curso > 6);

            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("El RUC de la empresa es: " + ruc);
            Console.WriteLine();
            Console.WriteLine("Nombre de la empresa: " + nomempresa);
            Console.WriteLine();
            Console.WriteLine("Cantidad de participantes: " + participantes);
            Console.WriteLine();
            Console.WriteLine("Curso a matricularse: " + curso);
            Console.WriteLine();
            switch (curso)
            {
                case 1:
                    preciocurso = 220.00;
                    costototal = participantes * preciocurso;
                    break;
                case 2:
                    preciocurso = 300.00;
                    costototal = participantes * preciocurso;
                    break;
                case 3:
                    preciocurso = 130.00;
                    costototal = participantes * preciocurso;
                    break;
                case 4:
                    preciocurso = 120.00;
                    costototal = participantes * preciocurso;
                    break;
                case 5:
                    preciocurso = 250.00;
                    costototal = participantes * preciocurso;
                    break;
                case 6:
                    preciocurso = 200.00;
                    costototal = participantes * preciocurso;

                    break;
            }
            Console.WriteLine("El costo del curso por persona es S/" + preciocurso);
            Console.WriteLine();
            Console.WriteLine("El costo total del curso es: " + costototal);
            Console.WriteLine("====================================");
        }
        public void matpersonas() 
        {
            int curso;
            double preciocurso=0, DNI, contador = 0, costoTotalAcumulado=0;
            string nombre, apellido,continuar,nom_cur="";

            do
            {
                if (contador == 15)
                {
                    Console.WriteLine("Se ha alcanzado el límite máximo de matrículas 15. No se pueden realizar más matrículas.");
                    break;
                }
                else 
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Escribir su DNI: ");
                        DNI = Convert.ToDouble(Console.ReadLine());
                        if (!(DNI < 100000000 && DNI > 9999999))
                        {
                            Console.Clear();
                            Console.WriteLine("DNI debe tener 8 dígitos");
                            Console.WriteLine("Presione cualquier tecla para volver a intentarlo");
                            Console.ReadKey();
                        }
                        else
                            break;
                    } while (true);

                    Console.WriteLine("Ingrese su nombre: ");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese sus apellidos: ");
                    apellido = Console.ReadLine();

                    do
                    {
                        Console.Clear();
                        Console.WriteLine("====================================");
                        Console.WriteLine("       Curso a matricularse ");
                        Console.WriteLine("[1] Ms. Excel");
                        Console.WriteLine("[2] Ms. Access");
                        Console.WriteLine("[3] Ms. Word");
                        Console.WriteLine("[4] Ms. PowerPoint");
                        Console.WriteLine("[5] AutoCAD");
                        Console.WriteLine("[6] Diseño Grafico");
                        Console.WriteLine("====================================");
                        Console.WriteLine();
                        curso = Convert.ToInt32(Console.ReadLine());
                    } while (curso < 1 || curso > 6);

                    switch (curso)
                    {
                        case 1:
                            nom_cur = "Ms. Excel";
                            preciocurso = 250.00;
                            break;
                        case 2:
                            nom_cur = "Ms. Access";
                            preciocurso = 270.00;
                            break;
                        case 3:
                            nom_cur = "Ms. Word";
                            preciocurso = 150.00;
                            break;
                        case 4:
                            nom_cur = "Ms. PowerPoint";
                            preciocurso = 140.00;
                            break;
                        case 5:
                            nom_cur = "AutoCAD";
                            preciocurso = 280.00;
                            break;
                        case 6:
                            nom_cur = "Diseño Grafico";
                            preciocurso = 230.00;
                            break;
                    }
                    costoTotalAcumulado += preciocurso;

                    Console.Clear();
                    Console.WriteLine("====================================");
                    Console.WriteLine("El DNI de la persona es: " + DNI);
                    Console.WriteLine();
                    Console.WriteLine("Nombre: " + nombre);
                    Console.WriteLine();
                    Console.WriteLine("Apellitos: " + apellido);
                    Console.WriteLine();
                    Console.WriteLine("Curso a matricularse: " + nom_cur);
                    Console.WriteLine();
                    Console.WriteLine("El costo del curso es S/ " + preciocurso);
                    Console.WriteLine("====================================");
                }

                contador = contador + 1;

                Console.WriteLine();
                Console.WriteLine("Número de matrículas realizadas: " + contador);
                Console.WriteLine();
                Console.WriteLine("Costo acumulado total: S/ " + costoTotalAcumulado);
                Console.WriteLine();

                Console.WriteLine("¿Desea realizar otra matrícula? (s/n): ");
                continuar = Console.ReadLine().ToLower();

                if (continuar != "s")
                {
                    Console.Clear();
                    Console.WriteLine("====================================");
                    Console.WriteLine("RESUMEN FINAL:");
                    Console.WriteLine("Total de matrículas: " + contador);
                    Console.WriteLine("Costo total acumulado: S/ " + costoTotalAcumulado);
                    Console.WriteLine("====================================");
                    Console.WriteLine("Presione cualquier tecla para continuar... ");
                    Console.ReadKey();
                }
            } while (continuar == "s" && contador <= 15);
        }
    }    
}
