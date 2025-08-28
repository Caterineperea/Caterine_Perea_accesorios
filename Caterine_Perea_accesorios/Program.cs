// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var accesorio = new Accesorios(); 
accesorio.Id = 1;
accesorio.Nombre = "Manilla acero";
accesorio.tipo = new Tipos() { Id = 1, Nombre = "Manilla" };
accesorio.Valor = 12000.0m;
accesorio.FechaCompra = DateTime.Now;
accesorio.Existe = true;
accesorio.Materiales = new List<Materiales>();
accesorio.Materiales.Add(new Materiales() { Id = 1, Nombrem = "Fimo" });
accesorio.Materiales.Add(new Materiales() { Id = 2, Nombrem = "Perla" });
accesorio.Materiales.Add(new Materiales() { Id = 3, Nombrem = "Plastimetal" });
accesorio.calidad = new Calidades() { Id = 1, Antialergico = false };


accesorio.Id = 2;
accesorio.Nombre = "Aretas";
accesorio.tipo = new Tipos() { Id = 1, Nombre = "Tejidos" };
accesorio.Valor = 25000.0m;
accesorio.FechaCompra = DateTime.Now;
accesorio.Existe = true;
accesorio.Materiales = new List<Materiales>();
accesorio.Materiales.Add(new Materiales() { Id = 1, Nombrem = "Mostacilla" });
accesorio.Materiales.Add(new Materiales() { Id = 2, Nombrem = "Base acero" });
accesorio.calidad = new Calidades() { Id = 1, Antialergico = true };

Console.WriteLine(accesorio.Nombre);
Console.WriteLine(accesorio.tipo.Nombre);
Console.WriteLine("---------");
foreach (var elemento in accesorio.Materiales)
{
    Console.WriteLine(elemento.Nombrem);
}

public class Tipos
{
    public int Id = 0;
    public String? Nombre = "";
    public List<Accesorios> Accesorios = new List<Accesorios>(); //plural lista de arreglos
}

public class Materiales
{
    public int Id = 0;
    public String? Nombrem;
}

public class Calidades
{
    public int Id = 0;
    public bool Antialergico = true;
}

public class Accesorios
{
    public int Id = 0;
    public String? Nombre = "";
    public decimal Valor = 0.0m;
    public DateTime FechaCompra = DateTime.Now;
    public bool Existe = true;
    public Tipos tipo = new Tipos(); //singular un solo dato
    public List<Materiales> Materiales = new List<Materiales>(); //plural lista de arreglos
    public Calidades calidad = new Calidades();
}
