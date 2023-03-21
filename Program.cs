Dictionary<string,double> dicCursos = new Dictionary<string, double>();


Console.WriteLine("1- Ingresar datos");
Console.WriteLine("2- Ver estadisticas");
Console.WriteLine("3- Finalizar");
int eleccion = IngresarEntero("Ingrese una de las tres opciones de arriba: ");

while (eleccion != 3)
{
    switch (eleccion)
{
    case 1:
    Recaudó(ref dicCursos);
    break;
    case 2:
    double max = 0; string cursomax=string.Empty;
    double promedio = 0;
    double total = 0;
    int cantCursos = dicCursos.Keys.Count();
    foreach(string curso in dicCursos.Keys)
    {
        if (dicCursos[curso] >= max){
            max = dicCursos[curso];
            cursomax = curso;
        }
        promedio += dicCursos[curso];
        total += dicCursos[curso];
    }
    Console.WriteLine("a) Recaudacion mas alta: $"+max+" "+cursomax);
    Console.WriteLine("b) Promedio entre cursos: $" + promedio/cantCursos);
    Console.WriteLine("c) Recaudacion total: $" + total);
    Console.WriteLine("d) Cantidad de cursos: " + cantCursos);
    break;
}
Console.WriteLine("Toque cualquier tecla para continuar"); Console.ReadLine();
Console.Clear();
Console.WriteLine("1 Ingresar datos");
Console.WriteLine("2 Ver estadisticas");
Console.WriteLine("3 Finalizar");
eleccion = IngresarEntero("Ingrese una de las tres opciones de arriba: ");
}

void Recaudó (ref Dictionary<string,double> cursos ){
    string curso = IngresarString("Ingrese el nombre del curso: ");
    int alumnos = IngresarEntero("Ingrese la cantidad de estudiantes del curso: ");

    double recaudacion = 0, cont = 1;
    cursos.Add(curso,0);
    for (int i = 0; i < alumnos; i++)
    {
        recaudacion += IngresarEntero("Ingrese el monto recaudado del alumno n°"+cont+": $");
        cont++;
    }
    cursos[curso] = recaudacion;
}
string IngresarString(string msg){
    Console.Write(msg);
    return Console.ReadLine();
}
int IngresarEntero(string msg){
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}