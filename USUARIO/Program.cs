using System;
using System.Collections.Generic;

class CorreoElect
{
    private string Correo;
    public CorreoElect(string Co) => Correo = Co;
    public string getCorreo() => Correo;
}
class Usuario
{
    private string Nombre;
    private List<CorreoElect> Correos;
    public Usuario(string Nombre)
    {
        this.Nombre = Nombre;
        Correos = new List<CorreoElect>();
    }
    public string getNombre() => Nombre;
    public void AgregaaCorreo(CorreoElect Co)=> Correos.Add(Co);
    public void Print() 
    {
        Console.WriteLine(Nombre);
        foreach(CorreoElect Co in Correos)
        {
            Console.WriteLine(Co.getCorreo());
        }
    }
    static void Main(string[] args)
    {
        Usuario U1 = new Usuario("Juan");
        Console.WriteLine(U1.getNombre());
        U1.AgregaaCorreo(new CorreoElect("juanito@gmail.com"));
        U1.AgregaaCorreo(new CorreoElect("juanito@yahoo.com.mx"));
        U1.Print();
    }

}
