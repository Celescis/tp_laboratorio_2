using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Wiki wiki = new Wiki();
            Wiki filtros = new Wiki();
            Wiki filtros2 = new Wiki();
            Inventario inventario = new Inventario();
            Inventario inventarioUno = new Inventario();
            Cubo cubo = new Cubo(ETipoMaterial.Diamante);
            Cubo cubo1 = new Cubo(ETipoMaterial.Diamante);
            Cubo cubo2 = new Cubo(ETipoMaterial.Piedra);
            Cubo cubo3 = new Cubo(ETipoMaterial.Madera);
            Herramienta tool = new Herramienta(ETipoHerramienta.Espada, ETipoMaterial.Diamante);
            Herramienta tool1 = new Herramienta(ETipoHerramienta.Pico, ETipoMaterial.Diamante);
            Herramienta tool2 = new Herramienta(ETipoHerramienta.Hacha, ETipoMaterial.Madera);
            Herramienta tool3 = new Herramienta(ETipoHerramienta.Pico, ETipoMaterial.Diamante);
            Herramienta tool4 = new Herramienta(ETipoHerramienta.Espada, ETipoMaterial.Piedra);
            Herramienta tool5 = new Herramienta(ETipoHerramienta.Pico, ETipoMaterial.Diamante);

            inventario.AgregarCubo(cubo);
            inventario.AgregarCubo(cubo1);
            inventario.AgregarCubo(cubo2);
            inventario.AgregarCubo(cubo3);
            inventario.AgregarHerramienta(tool1);
            inventario.AgregarHerramienta(tool3);
            inventario.AgregarHerramienta(tool5);
            inventario.AgregarHerramienta(tool4);

            inventarioUno.AgregarCubo(cubo);
            inventarioUno.AgregarCubo(cubo2);
            inventarioUno.AgregarCubo(cubo3);
            inventarioUno.AgregarHerramienta(tool);
            inventarioUno.AgregarHerramienta(tool1);
            inventarioUno.AgregarHerramienta(tool2);
            inventarioUno.AgregarHerramienta(tool3);


            Jugador uno = new Jugador("Cele", inventarioUno);
            Jugador dos = new Jugador("Gero", inventario);
            Jugador tres = new Jugador("Pipi", inventarioUno);
            Jugador cuatro = new Jugador("Kira",inventario);

            wiki += uno;
            wiki += dos;
            wiki += tres;
            wiki += cuatro;



            if (inventario.Capacidad == 10)
            {
                Console.WriteLine("No se agrego nada");
            }
            else
            {
                Console.WriteLine($"Se agregaron, nueva capacidad inventario de {dos.Nombre} es: {inventario.Capacidad}");
                Console.WriteLine($"Cantidad cubos: {inventario.CantidadCubos}");
                Console.WriteLine($"Cantidad herramientas: {inventario.CantidadHerramientas}");
                Console.WriteLine($"Se agregaron, nueva capacidad inventario de {uno.Nombre} es: {inventario.Capacidad}");
                Console.WriteLine($"Cantidad cubos: {inventarioUno.CantidadCubos}");
                Console.WriteLine($"Cantidad herramientas: {inventarioUno.CantidadHerramientas}");
            }

            if (wiki.GetJugador(uno.Nombre) is not null)
            {
                Console.WriteLine($"{uno.Nombre} se encuentra en la lista");
            }
            if (wiki.GetJugador(dos.Nombre) is not null)
            {
                Console.WriteLine($"{dos.Nombre} se encuentra en la lista");
            }
            if (wiki.GetJugador(tres.Nombre) is null)
            {
                Console.WriteLine($"{tres.Nombre} no se encuentra en la lista");
            }

            //Console.WriteLine(".......A.......");
            //Console.WriteLine(wiki.Mostrar());
            //Console.WriteLine("........A......");

            //filtros = Wiki.JugadoresConMasCubos(wiki);
            //Archivos.GuardarTxt(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Jugadores con mas Cubos.txt", filtros);
            //filtros2 = Wiki.JugadoresConMasHerramientas(wiki);
            //Archivos.GuardarTxt(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Jugadores con mas herramientas.txt", filtros2);
            //foreach (Jugador item in filtros.Jugadores)
            //{
            //    Console.WriteLine(item);
            //}

            ////ARCHIVOS TXT
            //Archivos.GuardarTxt(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\lista.txt", wiki);
            //Archivos.LeerTxt(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\lista.txt", out wiki);

            //SERIALIZACION XML
            Archivos.GuardarXml(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Prueba.xml", wiki);
            wiki = Archivos.LeerXml(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Prueba.xml");
            foreach (Jugador item in wiki.Jugadores)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadKey();

        }
    }
}
