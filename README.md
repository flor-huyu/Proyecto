> ![](./image1.png){width="3.725in" height="3.2916666666666665in"}

UNIVERSIDAD PRIVADA DOMINGO SAVIO

**SEDE LA PAZ - BOLIVIA**

**CARRERA DE INGENIERÍA INDUSTRIAL**

MATERIA: PROGRAMACIÓN NUMÉRICA Y APLICACIONES

**PROYECTO FORMATIVO DE INVESTIGACIÓN**:

**"DISEÑO DE UN SISTEMA DE CONTROL DE CALIDAD Y DEFECTOS"**

**Integrantes:**

Espejo Huyu Flor Fiorela

García Apaza Lucia Juliana

Zambrana Suarez Ignacio Andrey

**Fecha:** 31/08/26

La Paz -- Bolivia 2026

# **ÍNDICE** {#índice .TOC-Heading .unnumbered}

[1. INTRODUCCIÓN [3](#introducción)](#introducción)

[1.1. Contexto General [3](#contexto-general)](#contexto-general)

[1.1. Problemática [3](#problemática)](#problemática)

[1.2. Justificación [4](#justificación)](#justificación)

[1.4. Alcance [4](#alcance)](#alcance)

[1.5. Limitaciones [5](#limitaciones)](#limitaciones)

[2. OBJETIVOS [5](#objetivos)](#objetivos)

[2.1. Objetivo General [5](#objetivo-general)](#objetivo-general)

[2.2. Objetivos Específicos
[5](#objetivos-específicos)](#objetivos-específicos)

[3. MARCO TEÓRICO [6](#marco-teórico)](#marco-teórico)

[3.1. Programación y Algoritmos
[6](#programación-y-algoritmos)](#programación-y-algoritmos)

[3.2. Programación Orientada a Objetos (POO)
[6](#programación-orientada-a-objetos-poo)](#programación-orientada-a-objetos-poo)

[3.3. Estructuras de Datos y Arreglos
[6](#estructuras-de-datos-y-arreglos)](#estructuras-de-datos-y-arreglos)

[3.4. Estructuras Condicionales y Repetitivas
[7](#estructuras-condicionales-y-repetitivas)](#estructuras-condicionales-y-repetitivas)

[3.5. Manejo de Archivos y Persistencia de Datos
[7](#manejo-de-archivos-y-persistencia-de-datos)](#manejo-de-archivos-y-persistencia-de-datos)

[3.6. Validación y Manejo de Errores
[7](#validación-y-manejo-de-errores)](#validación-y-manejo-de-errores)

[3.7. Control de Calidad en Procesos Industriales
[8](#control-de-calidad-en-procesos-industriales)](#control-de-calidad-en-procesos-industriales)

[3.8. Tasa de Defectos y Criterio de Rechazo
[8](#tasa-de-defectos-y-criterio-de-rechazo)](#tasa-de-defectos-y-criterio-de-rechazo)

[3.9. Moda Estadística [8](#moda-estadística)](#moda-estadística)

[4. DESARROLLO DEL PROYECTO
[8](#desarrollo-del-proyecto)](#desarrollo-del-proyecto)

[4.1. Descripción General del Sistema
[8](#descripción-general-del-sistema)](#descripción-general-del-sistema)

[4.2. Estructura del Sistema
[9](#estructura-del-sistema)](#estructura-del-sistema)

[4.3. Gestión de Inspecciones
[10](#gestión-de-inspecciones)](#gestión-de-inspecciones)

[4.4. Validación de Datos
[11](#validación-de-datos)](#validación-de-datos)

[4.5. Listado de Inspecciones
[11](#listado-de-inspecciones)](#listado-de-inspecciones)

[4.6. Cálculo de la Tasa de Defectos
[11](#cálculo-de-la-tasa-de-defectos)](#cálculo-de-la-tasa-de-defectos)

[4.7. Identificación de Lotes Rechazados
[12](#identificación-de-lotes-rechazados)](#identificación-de-lotes-rechazados)

[4.8. Determinación del Tipo de Defecto Más Frecuente
[12](#determinación-del-tipo-de-defecto-más-frecuente)](#determinación-del-tipo-de-defecto-más-frecuente)

[4.9. Consulta de la Tasa por Inspección
[13](#consulta-de-la-tasa-por-inspección)](#consulta-de-la-tasa-por-inspección)

[4.10. Generación del Reporte de Calidad
[13](#generación-del-reporte-de-calidad)](#generación-del-reporte-de-calidad)

[4.11. Menú Principal y Navegación
[13](#menú-principal-y-navegación)](#menú-principal-y-navegación)

[4.12. Implementación en PSeInt
[14](#implementación-en-pseint)](#implementación-en-pseint)

[4.13. Implementación en C#
[14](#implementación-en-c)](#implementación-en-c)

[5. TECNOLOGÍAS Y HERRAMIENTAS UTILIZADAS
[15](#tecnologías-y-herramientas-utilizadas)](#tecnologías-y-herramientas-utilizadas)

[5.1. PSeInt [15](#pseint)](#pseint)

[5.2. C# [15](#c)](#c)

[5.3. Visual Studio [15](#visual-studio)](#visual-studio)

[5.4. Archivos TXT [15](#archivos-txt)](#archivos-txt)

[6. RESULTADOS DEL PROYECTO
[15](#resultados-del-proyecto)](#resultados-del-proyecto)

[6.1. Pruebas de Funcionamiento
[15](#pruebas-de-funcionamiento)](#pruebas-de-funcionamiento)

[6.3. Prueba del Tipo de Defecto Más Frecuente
[16](#prueba-del-tipo-de-defecto-más-frecuente)](#prueba-del-tipo-de-defecto-más-frecuente)

[7. CONCLUSIONES Y RECOMENDACIONES
[17](#conclusiones-y-recomendaciones)](#conclusiones-y-recomendaciones)

[7.1. Conclusiones [17](#conclusiones)](#conclusiones)

[7.2. Recomendaciones [18](#recomendaciones)](#recomendaciones)

[8. BIBLIOGRAFÍA [19](#bibliografía)](#bibliografía)

[9. ANEXOS [20](#anexo)](#anexo)

# INTRODUCCIÓN

#  Contexto General

En los procesos industriales, el control de calidad es una actividad
fundamental para garantizar que los productos cumplan con los estándares
establecidos antes de llegar al consumidor.

Durante una línea de producción se pueden encontrar diferentes tipos de
defectos. Por esta razón, es necesario registrar las inspecciones
realizadas a los productos y analizar los resultados obtenidos.

El presente proyecto propone el desarrollo de un **Sistema de Control de
Calidad y Defectos**, cuyo propósito es facilitar el registro y análisis
de las inspecciones realizadas en diferentes lotes de producción.

El sistema permitirá registrar información como la fecha de inspección,
nombre de la inspección, código del lote, cantidad inspeccionada,
cantidad de defectos encontrados y tipo principal de defecto.

Además, permitirá calcular automáticamente la tasa de defectos,
identificar lotes rechazados y determinar cuál es el tipo de defecto más
frecuente.

#  Problemática

En una línea de producción, realizar el control de calidad de manera
manual puede generar dificultades para organizar y analizar la
información obtenida durante las inspecciones.

Cuando los datos no se encuentran correctamente registrados, puede ser
complicado identificar cuáles son los lotes que presentan una cantidad
elevada de defectos o determinar qué tipo de defecto ocurre con mayor
frecuencia.

Esto puede retrasar la toma de decisiones y dificultar la identificación
de problemas dentro del proceso productivo.

Por ello, se plantea desarrollar un sistema que permita registrar,
organizar, calcular y analizar automáticamente la información
relacionada con los defectos encontrados durante las inspecciones de
calidad.

#  Justificación

El desarrollo de este sistema permite aplicar conocimientos de
programación a una situación relacionada directamente con la Ingeniería
Industrial.

La solución facilita el registro de inspecciones y permite obtener
información importante mediante cálculos automáticos.

El sistema también ayuda a identificar lotes que superan el límite
establecido del **5% de defectos**, permitiendo clasificarlos como
rechazados.

De esta manera, la herramienta puede contribuir a mejorar el control de
los procesos productivos y facilitar la toma de decisiones basada en los
datos registrados.

# 1.4. Alcance {#alcance .unnumbered}

El sistema permitirá:

-   Registrar inspecciones de calidad.

-   Registrar fecha y nombre de la inspección.

-   Registrar el código de lote.

-   Registrar la cantidad inspeccionada.

-   Registrar la cantidad de defectos encontrados.

-   Registrar el tipo principal de defecto.

-   Listar las inspecciones registradas.

-   Calcular la tasa de defectos.

-   Identificar lotes rechazados.

-   Determinar el tipo de defecto más frecuente.

-   Generar un reporte general en formato TXT.

-   Guardar y cargar información mediante archivos.

-   Ejecutarse mediante un menú de opciones.

# 1.5. Limitaciones {#limitaciones .unnumbered}

El sistema está diseñado para funcionar como una herramienta académica
de control de calidad.

Entre sus principales limitaciones se encuentran:

-   El sistema utiliza una cantidad máxima de **100 registros**.

-   La información se almacena mediante archivos locales.

-   No utiliza una base de datos.

-   El sistema no está conectado directamente a máquinas o sensores
    industriales.

-   La información depende de los datos ingresados por el usuario.

# 2. OBJETIVOS {#objetivos .unnumbered}

# 2.1. Objetivo General {#objetivo-general .unnumbered}

Desarrollar un sistema informático de control de calidad que permita
registrar y analizar inspecciones de producción, calcular tasas de
defectos, identificar lotes rechazados y determinar los tipos de
defectos más frecuentes mediante PSeInt y C#.

# 2.2. Objetivos Específicos {#objetivos-específicos .unnumbered}

-   Diseñar un algoritmo para registrar inspecciones de calidad.

-   Implementar la solución mediante PSeInt.

-   Desarrollar el sistema utilizando el lenguaje C#.

-   Validar los datos ingresados por el usuario.

-   Calcular automáticamente la tasa de defectos de cada lote.

-   Identificar los lotes cuya tasa de defectos sea superior al 5%.

-   Determinar el tipo de defecto más frecuente mediante la moda.

-   Permitir consultar las inspecciones almacenadas.

-   Generar un reporte general de calidad en un archivo TXT.

-   Aplicar conceptos de programación a un problema relacionado con la
    industria.

# 3. MARCO TEÓRICO {#marco-teórico .unnumbered}

# 3.1. Programación y Algoritmos {#programación-y-algoritmos .unnumbered}

Un algoritmo es un conjunto ordenado de pasos que permite solucionar un
problema determinado.

En este proyecto, el algoritmo permite establecer las operaciones
necesarias para registrar una inspección, procesar sus datos y obtener
resultados relacionados con la calidad de los productos.

# 3.2. Programación Orientada a Objetos (POO) {#programación-orientada-a-objetos-poo .unnumbered}

La Programación Orientada a Objetos es un paradigma de programación que
organiza un programa mediante clases y objetos.

En C#, la estructura principal del proyecto se encuentra dentro de una
clase denominada Program, donde se implementan los diferentes métodos
utilizados por el sistema.

# 3.3. Estructuras de Datos y Arreglos {#estructuras-de-datos-y-arreglos .unnumbered}

Los arreglos permiten almacenar varios elementos del mismo tipo dentro
de una estructura organizada.

En el proyecto se utilizan arreglos paralelos para almacenar información
de las inspecciones, como:

-   Fechas.

-   Nombres de inspecciones.

-   Lotes.

-   Cantidades inspeccionadas.

-   Cantidades de defectos.

-   Tipos de defectos.

Esto permite mantener organizada la información registrada.

# 3.4. Estructuras Condicionales y Repetitivas {#estructuras-condicionales-y-repetitivas .unnumbered}

Las estructuras condicionales permiten ejecutar determinadas
instrucciones dependiendo de una condición.

Por ejemplo, el sistema utiliza una condición para determinar si un lote
debe ser rechazado:

**Si tasa de defectos \> 5%, el lote es rechazado.**

También se utilizan estructuras repetitivas para recorrer los registros
almacenados y realizar cálculos.

# 3.5. Manejo de Archivos y Persistencia de Datos {#manejo-de-archivos-y-persistencia-de-datos .unnumbered}

La persistencia permite conservar la información después de cerrar el
programa.

En este proyecto se utilizan archivos de texto para guardar y recuperar
los registros de inspecciones.

También se genera un archivo denominado:

**reporte_calidad_resumen.txt**

que contiene un resumen de los resultados obtenidos.

# 3.6. Validación y Manejo de Errores {#validación-y-manejo-de-errores .unnumbered}

La validación permite comprobar que los datos introducidos por el
usuario sean correctos.

El sistema verifica, por ejemplo, que:

-   La cantidad inspeccionada sea mayor que cero.

-   La cantidad de defectos no sea negativa.

-   Los defectos no superen la cantidad inspeccionada.

-   El lote no se encuentre registrado anteriormente.

-   Las opciones del menú sean válidas.

# 3.7. Control de Calidad en Procesos Industriales {#control-de-calidad-en-procesos-industriales .unnumbered}

El control de calidad comprende las actividades destinadas a verificar
que los productos cumplan con los requisitos establecidos.

La inspección permite detectar defectos y obtener información que
posteriormente puede utilizarse para mejorar los procesos productivos.

# 3.8. Tasa de Defectos y Criterio de Rechazo {#tasa-de-defectos-y-criterio-de-rechazo .unnumbered}

La tasa de defectos representa el porcentaje de productos defectuosos
respecto a la cantidad total inspeccionada.

La fórmula utilizada es:

**Tasa de defectos = (Cantidad de defectos / Cantidad inspeccionada) ×
100**

Para el proyecto se establece que:

**Si la tasa es mayor al 5%, el lote es RECHAZADO.**

En caso contrario, el lote es considerado **ACEPTADO**.

# 3.9. Moda Estadística {#moda-estadística .unnumbered}

La moda es el valor que aparece con mayor frecuencia dentro de un
conjunto de datos.

En este proyecto se utiliza para determinar cuál es el **tipo de defecto
más frecuente** entre las inspecciones registradas.

# 4. DESARROLLO DEL PROYECTO {#desarrollo-del-proyecto .unnumbered}

# 4.1. Descripción General del Sistema {#descripción-general-del-sistema .unnumbered}

El sistema desarrollado permite gestionar información relacionada con
inspecciones de calidad realizadas a diferentes lotes de producción.

El usuario interactúa con un menú principal que presenta siete opciones:

1.  Registrar nueva inspección.

2.  Listar todas las inspecciones.

3.  Ver lotes rechazados.

4.  Ver tipo de defecto más frecuente.

5.  Calcular tasa de defectos por inspección.

6.  Generar reporte general en TXT.

7.  Salir.

Cada opción ejecuta una función específica del sistema.

# 4.2. Estructura del Sistema {#estructura-del-sistema .unnumbered}

El sistema se divide principalmente en los siguientes componentes:

**Entrada de datos → Procesamiento → Resultados → Almacenamiento**

**Entrada**

El usuario proporciona:

-   Fecha.

-   Nombre de inspección.

-   Código de lote.

-   Cantidad inspeccionada.

-   Cantidad de defectos.

-   Tipo de defecto.

**Procesamiento**

El sistema:

-   Valida los datos.

-   Calcula la tasa de defectos.

-   Determina si el lote está rechazado.

-   Cuenta la frecuencia de los tipos de defectos.

-   Genera información estadística.

**Salida**

El sistema muestra:

-   Inspecciones registradas.

-   Tasas de defectos.

-   Lotes rechazados.

-   Defecto más frecuente.

-   Reporte general.

# 4.3. Gestión de Inspecciones {#gestión-de-inspecciones .unnumbered}

Para registrar una inspección, el usuario selecciona la opción **1**.

El sistema solicita:

1.  Fecha.

2.  Nombre de inspección.

3.  Código de lote.

4.  Cantidad inspeccionada.

5.  Cantidad de defectos.

6.  Tipo principal de defecto.

Posteriormente, la información se almacena en los arreglos
correspondientes.

Antes de guardar los datos se realizan diferentes validaciones para
evitar información incorrecta.

# 4.4. Validación de Datos {#validación-de-datos .unnumbered}

El sistema verifica que la cantidad inspeccionada sea mayor a cero.

También comprueba que la cantidad de defectos:

**Sea mayor o igual a cero y menor o igual a la cantidad
inspeccionada.**

Además, se verifica que el código del lote no se encuentre registrado
previamente.

Estas validaciones permiten mejorar la confiabilidad de la información
almacenada.

# 4.5. Listado de Inspecciones {#listado-de-inspecciones .unnumbered}

La opción **2** permite visualizar todas las inspecciones registradas.

Para cada registro se muestran:

-   Fecha.

-   Nombre de inspección.

-   Lote.

-   Cantidad inspeccionada.

-   Defectos.

-   Tipo de defecto.

-   Tasa de defectos.

La tasa se calcula automáticamente para cada registro.

# 4.6. Cálculo de la Tasa de Defectos {#cálculo-de-la-tasa-de-defectos .unnumbered}

La tasa de defectos se calcula mediante:

**Tasa = (Defectos / Cantidad inspeccionada) × 100**

**Ejemplo:**

Cantidad inspeccionada:

**100 unidades**

Cantidad de defectos:

**8 unidades**

Entonces:

**Tasa = (8 / 100) × 100**

**Tasa = 8%**

Como el resultado es superior al 5%, el lote sería:

**RECHAZADO**

# 4.7. Identificación de Lotes Rechazados {#identificación-de-lotes-rechazados .unnumbered}

El sistema analiza cada inspección registrada.

Cuando:

**Tasa de defectos \> 5%**

el sistema identifica automáticamente el lote como **RECHAZADO**.

Cuando:

**Tasa de defectos ≤ 5%**

el lote se considera **ACEPTADO**.

La opción **3** permite visualizar todos los lotes rechazados junto con
su información correspondiente.

# 4.8. Determinación del Tipo de Defecto Más Frecuente {#determinación-del-tipo-de-defecto-más-frecuente .unnumbered}

La opción **4** permite determinar cuál es el tipo de defecto que
aparece con mayor frecuencia.

El sistema compara los tipos de defecto registrados y cuenta cuántas
veces aparece cada uno.

El tipo que presenta la mayor cantidad de apariciones es mostrado como:

**Tipo de defecto más frecuente.**

# 4.9. Consulta de la Tasa por Inspección {#consulta-de-la-tasa-por-inspección .unnumbered}

La opción **5** permite consultar la tasa de defectos correspondiente a
un lote específico.

El usuario introduce el código del lote.

El sistema busca el registro y muestra:

-   Lote.

-   Nombre de inspección.

-   Tasa de defectos.

-   Resultado: ACEPTADO o RECHAZADO.

# 4.10. Generación del Reporte de Calidad {#generación-del-reporte-de-calidad .unnumbered}

La opción **6** permite generar un archivo TXT denominado:

**reporte_calidad_resumen.txt**

El archivo contiene:

-   Fecha de generación.

-   Total de inspecciones.

-   Detalle de las inspecciones.

-   Cantidad inspeccionada.

-   Cantidad de defectos.

-   Tasa de defectos.

-   Tipo de defecto.

-   Lotes rechazados.

Esto permite conservar un resumen de los resultados obtenidos.

# 4.11. Menú Principal y Navegación {#menú-principal-y-navegación .unnumbered}

El menú principal permite al usuario seleccionar las diferentes
funciones del sistema.

El programa permanece ejecutándose mientras la opción seleccionada sea
diferente de **7**.

Cuando el usuario selecciona:

**Salir**

el sistema guarda la información y finaliza la ejecución.

# 4.12. Implementación en PSeInt {#implementación-en-pseint .unnumbered}

Antes de realizar la implementación en C#, se puede representar la
lógica del sistema mediante PSeInt.

La estructura general es:

**Inicio → Mostrar menú → Seleccionar opción → Ejecutar proceso →
Regresar al menú → Salir**

PSeInt permite comprobar la lógica del algoritmo antes de realizar su
implementación en un lenguaje de programación como C#.

# 4.13. Implementación en C# {#implementación-en-c .unnumbered}

La implementación principal del proyecto se realiza mediante C#.

El programa utiliza:

-   Console para la interacción con el usuario.

-   if para las condiciones.

-   switch para el menú.

-   for para recorrer registros.

-   Arreglos para almacenar información.

-   Métodos para dividir las funciones del programa.

-   StringBuilder para construir el reporte.

-   Archivos TXT para almacenar información.

La estructura modular permite que cada función del sistema tenga una
responsabilidad específica.

# 5. TECNOLOGÍAS Y HERRAMIENTAS UTILIZADAS {#tecnologías-y-herramientas-utilizadas .unnumbered}

# 5.1. PSeInt {#pseint .unnumbered}

Se utiliza PSeInt para diseñar y comprobar los algoritmos mediante
pseudocódigo.

# 5.2. C# {#c .unnumbered}

C# es utilizado para desarrollar la versión funcional del sistema.

Permite implementar estructuras condicionales, repetitivas, arreglos,
métodos, validaciones y manejo de archivos.

# 5.3. Visual Studio {#visual-studio .unnumbered}

Visual Studio se utiliza como entorno de desarrollo para escribir,
compilar y ejecutar el programa desarrollado en C#.

# 5.4. Archivos TXT {#archivos-txt .unnumbered}

Los archivos de texto permiten almacenar información relacionada con las
inspecciones y generar el reporte general de calidad.

# 6. RESULTADOS DEL PROYECTO {#resultados-del-proyecto .unnumbered}

# 6.1. Pruebas de Funcionamiento {#pruebas-de-funcionamiento .unnumbered}

Para comprobar el funcionamiento del sistema se realizan diferentes
pruebas mediante el ingreso de datos de ejemplo.

Por ejemplo:

**Fecha:** 28/08/2026\
**Nombre de inspección:** Control lote A\
**Lote:** L001\
**Cantidad inspeccionada:** 100\
**Defectos encontrados:** 3\
**Tipo de defecto:** Empaque

Resultado:

**Tasa de defectos = 3%**

Por lo tanto:

**Lote ACEPTADO.**

**6.2. Prueba de Lote Rechazado**

Datos:

**Cantidad inspeccionada:** 100\
**Defectos encontrados:** 8

Cálculo:

**Tasa = (8 / 100) × 100**

**Tasa = 8%**

Como:

**8% \> 5%**

Resultado:

**Lote RECHAZADO.**

# 6.3. Prueba del Tipo de Defecto Más Frecuente {#prueba-del-tipo-de-defecto-más-frecuente .unnumbered}

Se pueden registrar diferentes inspecciones, por ejemplo:

  -----------------------------------------------------------------------
  **INSPECCIÓN**                      **TIPO DE DEFECTO**
  ----------------------------------- -----------------------------------
  L001                                Empaque

  L002                                Etiquetado

  L003                                Empaque

  L004                                Empaque

  L005                                Etiquetado
  -----------------------------------------------------------------------

El sistema determina que:

**Empaque = 3 apariciones**

**Etiquetado = 2 apariciones**

Por lo tanto:

**Defecto más frecuente: Empaque.**

**6.4. Generación del Reporte**

Después de seleccionar la opción **6**, el sistema genera:

**reporte_calidad_resumen.txt**

Este archivo contiene el resumen de las inspecciones y los lotes
rechazados.

# 7. CONCLUSIONES Y RECOMENDACIONES {#conclusiones-y-recomendaciones .unnumbered}

# 7.1. Conclusiones {#conclusiones .unnumbered}

El desarrollo del **Sistema de Control de Calidad y Defectos** permitió
aplicar conceptos de programación a una situación relacionada con los
procesos industriales.

El sistema permite registrar inspecciones, almacenar información,
calcular automáticamente la tasa de defectos e identificar los lotes que
superan el límite establecido del 5%.

También permite determinar el tipo de defecto más frecuente mediante la
frecuencia de los datos registrados y generar un reporte general en
formato TXT.

La implementación en PSeInt facilita la comprensión de la lógica del
algoritmo, mientras que C# permite convertir dicha lógica en una
aplicación funcional.

De esta manera, el proyecto demuestra cómo una herramienta informática
puede contribuir al análisis y control de información dentro de un
proceso productivo.

# 7.2. Recomendaciones {#recomendaciones .unnumbered}

Se recomienda mantener actualizada la información de las inspecciones
para obtener resultados confiables.

También se recomienda validar cuidadosamente los datos ingresados por
los usuarios para evitar errores en los cálculos.

Como mejora futura, el sistema podría incorporar una base de datos,
gráficos estadísticos, usuarios con diferentes niveles de acceso y
conexión con sistemas reales de producción.

# 8. BIBLIOGRAFÍA {#bibliografía .unnumbered}

International Organization for Standardization. (2015). *ISO 9001:2015
--- Sistemas de gestión de calidad --- Requisitos*.
[https://www.iso.org/es/contents/data/standard/06/20/62085.html](https://www.iso.org/es/contents/data/standard/06/20/62085.html?utm_source=chatgpt.com)

International Organization for Standardization. (2026). *Familia ISO
9000 --- Gestión de la calidad*.
[https://www.iso.org/es/normas/mas-comunes/familia-iso-9000](https://www.iso.org/es/normas/mas-comunes/familia-iso-9000?utm_source=chatgpt.com)

International Organization for Standardization. (2026). *Principios de
gestión de la calidad --- Su base para el éxito*.
[https://www.iso.org/es/contents/data/publication/10/00/PUB100080.html](https://www.iso.org/es/contents/data/publication/10/00/PUB100080.html?utm_source=chatgpt.com)

Microsoft. (2022). *Realizar operaciones básicas de entrada y salida de
archivos en Visual C#*. Microsoft Learn.
[https://learn.microsoft.com/en-us/troubleshoot/developer/visualstudio/csharp/language-compilers/file-io-operation](https://learn.microsoft.com/en-us/troubleshoot/developer/visualstudio/csharp/language-compilers/file-io-operation?utm_source=chatgpt.com)

# ANEXO

> **Anexo 1**
>
> ![HGUZHHX](./image2.jpeg){width="4.5151520122484685in"
> height="2.704002624671916in"}
>
> Listado del programa en C#. Elaboración propia
>
> **Anexo 2**
>
> ![](./image3.jpeg){width="4.529753937007874in"
> height="2.8787871828521436in"}
>
> Ejecución del programa en C#. Elaboración propia
