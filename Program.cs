using System;
using System.Text;

namespace Proyecto4_ControlCalidad
{
    class Program
    {
        // ==================================================
        // BLOQUE 1: CONFIGURACIÓN GLOBAL
        // ==================================================
        const string NOMBRE_ARCHIVO = "calidad.dat.txt";
        const int MAX_REGISTROS = 100;

        // ARREGLOS PARALELOS
        static string[] fechas = new string[MAX_REGISTROS];
        static string[] nombresInspeccion = new string[MAX_REGISTROS];
        static string[] lotes = new string[MAX_REGISTROS];
        static int[] cantInspeccionadas = new int[MAX_REGISTROS];
        static int[] cantDefectos = new int[MAX_REGISTROS];
        static string[] tiposDefecto = new string[MAX_REGISTROS];

        static int totalRegistros = 0;

        // ==================================================
        // BLOQUE 2: PUNTO DE ENTRADA Y MENÚ PRINCIPAL
        // ==================================================
        static void Main(string[] args)
        {
            CargarDatosDesdeArchivo();

            int opcion;

            do
            {
                Console.Clear();

                MostrarEncabezado();
                MostrarMenu();

                Console.Write("\nSeleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    opcion = 0;
                }

                ProcesarOpcion(opcion);

                if (opcion != 7)
                {
                    Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
                    Console.ReadKey();
                }

            } while (opcion != 7);

            GuardarDatosEnArchivo();

            Console.WriteLine("\nDatos guardados. ¡Saliendo del sistema!");
        }

        // ==================================================
        // ENCABEZADO
        // ==================================================
        static void MostrarEncabezado()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("==================================================");
            Console.WriteLine("   PROYECTO 4: CONTROL DE CALIDAD Y DEFECTOS");
            Console.WriteLine("           ODS 9 – INDUSTRIA E INNOVACIÓN");
            Console.WriteLine("==================================================");

            Console.ResetColor();
        }

        // ==================================================
        // MENÚ
        // ==================================================
        static void MostrarMenu()
        {
            Console.WriteLine("\nMENÚ DE OPCIONES:");
            Console.WriteLine("1. Registrar nueva inspección");
            Console.WriteLine("2. Listar todas las inspecciones");
            Console.WriteLine("3. Ver lotes rechazados (>5% defectos)");
            Console.WriteLine("4. Ver tipo de defecto más frecuente");
            Console.WriteLine("5. Calcular tasa de defectos por inspección");
            Console.WriteLine("6. Generar reporte general (archivo TXT)");
            Console.WriteLine("7. Salir");
        }

        // ==================================================
        // PROCESAR OPCIÓN
        // ==================================================
        static void ProcesarOpcion(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    RegistrarInspeccion();
                    break;

                case 2:
                    ListarInspecciones();
                    break;

                case 3:
                    MostrarLotesRechazados();
                    break;

                case 4:
                    MostrarDefectoMasFrecuente();
                    break;

                case 5:
                    CalcularTasaIndividual();
                    break;

                case 6:
                    GenerarReporteTXT();
                    break;

                case 7:
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opción inválida. Intente nuevamente.");
                    Console.ResetColor();
                    break;
            }
        }

        // ==================================================
        // 1. REGISTRAR NUEVA INSPECCIÓN
        // ==================================================
        static void RegistrarInspeccion()
        {
            if (totalRegistros >= MAX_REGISTROS)
            {
                Console.WriteLine("Memoria llena. No se pueden agregar más registros.");
                return;
            }

            Console.WriteLine("\n--- REGISTRO DE INSPECCIÓN ---");

            // FECHA
            Console.Write("Fecha (dd/MM/aaaa): ");
            string fecha = Console.ReadLine();

            // NOMBRE DE INSPECCIÓN
            Console.Write("Nombre de inspección: ");
            string nombreInspeccion = Console.ReadLine().Trim();

            // LOTE ÚNICO
            string lote;
            bool existe;

            do
            {
                Console.Write("Código de lote: ");

                lote = Console.ReadLine().Trim().ToUpper();

                existe = BuscarIndiceLote(lote) != -1;

                if (existe)
                {
                    Console.WriteLine("Este lote ya está registrado.");
                }

            } while (existe);

            // CANTIDAD INSPECCIONADA
            Console.Write("Cantidad inspeccionada: ");

            int cant;

            if (!int.TryParse(Console.ReadLine(), out cant))
            {
                Console.WriteLine("Debe ingresar un número válido.");
                return;
            }

            if (cant <= 0)
            {
                Console.WriteLine("La cantidad debe ser mayor a cero.");
                return;
            }

            // CANTIDAD DE DEFECTOS
            Console.Write("Cantidad de defectos encontrados: ");

            int defs;

            if (!int.TryParse(Console.ReadLine(), out defs))
            {
                Console.WriteLine("Debe ingresar un número válido.");
                return;
            }

            if (defs < 0 || defs > cant)
            {
                Console.WriteLine("Número de defectos inválido.");
                return;
            }

            // TIPO DE DEFECTO
            Console.Write("Tipo principal de defecto: ");
            string tipo = Console.ReadLine();

            // GUARDAR DATOS
            fechas[totalRegistros] = fecha;
            nombresInspeccion[totalRegistros] = nombreInspeccion;
            lotes[totalRegistros] = lote;
            cantInspeccionadas[totalRegistros] = cant;
            cantDefectos[totalRegistros] = defs;
            tiposDefecto[totalRegistros] = tipo;

            totalRegistros++;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nInspección registrada con éxito.");
            Console.ResetColor();
        }

        // ==================================================
        // BÚSQUEDA AUXILIAR DE LOTE
        // ==================================================
        static int BuscarIndiceLote(string loteBuscado)
        {
            for (int i = 0; i < totalRegistros; i++)
            {
                if (lotes[i] == loteBuscado)
                {
                    return i;
                }
            }

            return -1;
        }

        // ==================================================
        // 2. LISTAR TODAS LAS INSPECCIONES
        // ==================================================
        static void ListarInspecciones()
        {
            if (totalRegistros == 0)
            {
                Console.WriteLine("Sin registros aún.");
                return;
            }

            Console.WriteLine("\n--- LISTADO DE INSPECCIONES ---");

            Console.WriteLine(
                $"{"Fecha",-12}" +
                $"{"Nombre Inspección",-22}" +
                $"{"Lote",-10}" +
                $"{"Cantidad",-12}" +
                $"{"Defectos",-10}" +
                $"{"Tipo Defecto",-20}" +
                $"{"Tasa %",-8}"
            );

            Console.WriteLine(new string('-', 94));

            for (int i = 0; i < totalRegistros; i++)
            {
                double tasa =
                    (double)cantDefectos[i] /
                    cantInspeccionadas[i] * 100;

                Console.WriteLine(
                    $"{fechas[i],-12}" +
                    $"{nombresInspeccion[i],-22}" +
                    $"{lotes[i],-10}" +
                    $"{cantInspeccionadas[i],-12}" +
                    $"{cantDefectos[i],-10}" +
                    $"{tiposDefecto[i],-20}" +
                    $"{tasa:F2}%"
                );
            }
        }

        // ==================================================
        // 3. MOSTRAR LOTES RECHAZADOS
        // ==================================================
        static void MostrarLotesRechazados()
        {
            Console.WriteLine("\n--- LOTES RECHAZADOS (TASA > 5%) ---");

            bool hayRechazo = false;

            for (int i = 0; i < totalRegistros; i++)
            {
                double tasa =
                    (double)cantDefectos[i] /
                    cantInspeccionadas[i] * 100;

                if (tasa > 5)
                {
                    Console.WriteLine(
                        $"Lote: {lotes[i]} | " +
                        $"Inspección: {nombresInspeccion[i]} | " +
                        $"Fecha: {fechas[i]} | " +
                        $"Tasa: {tasa:F2}%"
                    );

                    hayRechazo = true;
                }
            }

            if (!hayRechazo)
            {
                Console.WriteLine(
                    "Todos los lotes cumplen con el límite aceptable."
                );
            }
        }

        // ==================================================
        // 4. DEFECTO MÁS FRECUENTE
        // ==================================================
        static void MostrarDefectoMasFrecuente()
        {
            if (totalRegistros == 0)
            {
                Console.WriteLine("Sin datos.");
                return;
            }

            string actualTipo = "";
            int maxCont = 0;

            for (int i = 0; i < totalRegistros; i++)
            {
                int cont = 0;

                for (int j = 0; j < totalRegistros; j++)
                {
                    if (tiposDefecto[i] == tiposDefecto[j])
                    {
                        cont++;
                    }
                }

                if (cont > maxCont)
                {
                    maxCont = cont;
                    actualTipo = tiposDefecto[i];
                }
            }

            Console.WriteLine(
                $"\nTipo de defecto más frecuente: {actualTipo}"
            );

            Console.WriteLine(
                $"Aparece {maxCont} veces."
            );
        }

        // ==================================================
        // 5. CALCULAR TASA INDIVIDUAL
        // ==================================================
        static void CalcularTasaIndividual()
        {
            Console.Write("\nIngrese lote para consultar: ");

            string l = Console.ReadLine().Trim().ToUpper();

            int idx = BuscarIndiceLote(l);

            if (idx == -1)
            {
                Console.WriteLine("Lote no encontrado.");
                return;
            }

            double tasa =
                (double)cantDefectos[idx] /
                cantInspeccionadas[idx] * 100;

            Console.WriteLine(
                $"\nLote: {l}"
            );

            Console.WriteLine(
                $"Nombre de inspección: {nombresInspeccion[idx]}"
            );

            Console.WriteLine(
                $"Tasa de defectos: {tasa:F2}%"
            );

            if (tasa > 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("RESULTADO: RECHAZADO");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("RESULTADO: ACEPTADO");
                Console.ResetColor();
            }
        }

        // ==================================================
        // 6. GENERAR REPORTE TXT
        // ==================================================
        static void GenerarReporteTXT()
        {
            string ruta = "reporte_calidad_resumen.txt";

            StringBuilder contenido = new StringBuilder();

            contenido.AppendLine("===========================================");
            contenido.AppendLine("PROYECTO 4: REPORTE DE CALIDAD Y DEFECTOS");
            contenido.AppendLine(
                $"Fecha generación: {DateTime.Now:dd/MM/yyyy HH:mm}"
            );
            contenido.AppendLine(
                "ODS 9 – INDUSTRIA, INNOVACIÓN E INFRAESTRUCTURA"
            );
            contenido.AppendLine("===========================================");

            contenido.AppendLine(
                $"Total inspecciones: {totalRegistros}\n"
            );

            contenido.AppendLine("DETALLE:");

            for (int i = 0; i < totalRegistros; i++)
            {
                double tasa =
                    (double)cantDefectos[i] /
                    cantInspeccionadas[i] * 100;

                contenido.AppendLine(
                    $"{fechas[i]} | " +
                    $"Inspección: {nombresInspeccion[i]} | " +
                    $"Lote: {lotes[i]} | " +
                    $"Inspeccionados: {cantInspeccionadas[i]} | " +
                    $"Defectos: {cantDefectos[i]} | " +
                    $"Tasa: {tasa:F2}% | " +
                    $"Tipo: {tiposDefecto[i]}"
                );
            }

            // LOTES RECHAZADOS
            contenido.AppendLine(
                "\n--- LOTES RECHAZADOS (>5%) ---"
            );

            bool hayRechazados = false;

            for (int i = 0; i < totalRegistros; i++)
            {
                double tasa =
                    (double)cantDefectos[i] /
                    cantInspeccionadas[i] * 100;

                if (tasa > 5)
                {
                    contenido.AppendLine(
                        $"→ {lotes[i]} | " +
                        $"Inspección: {nombresInspeccion[i]} | " +
                        $"Tasa: {tasa:F2}%"
                    );

                    hayRechazados = true;
                }
            }

            if (!hayRechazados)
            {
                contenido.AppendLine(
                    "No existen lotes rechazados."
                );
            }

            System.IO.File.WriteAllText(
                ruta,
                contenido.ToString()
            );

            Console.WriteLine(
                $"\nReporte generado exitosamente: {ruta}"
            );
        }

        // ==================================================
        // BLOQUE 4: CARGAR DATOS DESDE ARCHIVO
        // ==================================================
        static void CargarDatosDesdeArchivo()
        {
            if (!System.IO.File.Exists(NOMBRE_ARCHIVO))
            {
                Console.WriteLine(
                    $"Archivo {NOMBRE_ARCHIVO} no existe. Iniciando vacío."
                );

                return;
            }

            try
            {
                string[] lineas =
                    System.IO.File.ReadAllLines(NOMBRE_ARCHIVO);

                foreach (string linea in lineas)
                {
                    if (string.IsNullOrWhiteSpace(linea))
                    {
                        continue;
                    }

                    if (totalRegistros >= MAX_REGISTROS)
                    {
                        break;
                    }

                    string[] campos = linea.Split('|');

                    // AHORA SON 6 CAMPOS
                    if (campos.Length == 6)
                    {
                        fechas[totalRegistros] = campos[0];
                        nombresInspeccion[totalRegistros] = campos[1];
                        lotes[totalRegistros] = campos[2];

                        cantInspeccionadas[totalRegistros] =
                            int.Parse(campos[3]);

                        cantDefectos[totalRegistros] =
                            int.Parse(campos[4]);

                        tiposDefecto[totalRegistros] = campos[5];

                        totalRegistros++;
                    }
                }

                Console.WriteLine(
                    $"Datos cargados: {totalRegistros} registros"
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    $"Error al cargar: {ex.Message}"
                );
            }
        }

        // ==================================================
        // GUARDAR DATOS EN ARCHIVO
        // ==================================================
        static void GuardarDatosEnArchivo()
        {
            try
            {
                using (
                    System.IO.StreamWriter sw =
                    new System.IO.StreamWriter(NOMBRE_ARCHIVO)
                )
                {
                    for (int i = 0; i < totalRegistros; i++)
                    {
                        string linea =
                            $"{fechas[i]}|" +
                            $"{nombresInspeccion[i]}|" +
                            $"{lotes[i]}|" +
                            $"{cantInspeccionadas[i]}|" +
                            $"{cantDefectos[i]}|" +
                            $"{tiposDefecto[i]}";

                        sw.WriteLine(linea);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    $"Error guardando: {ex.Message}"
                );
            }
        }
    }
}