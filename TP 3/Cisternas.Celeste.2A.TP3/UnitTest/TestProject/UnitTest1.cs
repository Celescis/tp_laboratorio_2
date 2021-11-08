using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class UnitTest
    {
        /// <summary>
        /// Prueba de pasarle un nombre de usuario y que busque si se encuentra en la lista de jugadores, de no estar, crea uno nuevo con ese usuario
        /// </summary>
        [TestMethod]
        public void GetJugador_CuandoEncuentraElNombreONo_DeberiaRetornarElJugadorOUnoNuevo()
        {
            //Arrange
            Wiki lista = new Wiki();
            string nombre = "celeste22";
            Jugador play = new Jugador(nombre);
            lista.Jugadores.Add(play);
            Jugador jugadorRecibido;


            //Act
            jugadorRecibido = lista.GetJugador(nombre);

            //Assert
            Assert.AreEqual(nombre, jugadorRecibido.Nombre);

        }

        /// <summary>
        /// Prueba que se agregue un cubo al inventario
        /// </summary>
        [TestMethod]
        public void AgregarCubo_RecibeUnInventarioyUnCubo_DeberiaAgregarUnCuboAlInventario()
        {
            //Arrange
            Inventario inv = new Inventario();
            Cubo cubo = new Cubo(ETipoMaterial.Madera);

            //Assert
            Assert.IsTrue(inv.AgregarCubo(cubo));
        }

        /// <summary>
        /// Prueba que se agregue una herramienta al inventario
        /// </summary>
        [TestMethod]
        public void AgregarHerramienta_RecibeUnInventarioyUnaHerramienta_DeberiaAgregarUnaHerramientaAlInventario()
        {
            //Arrange
            Inventario inv = new Inventario();
            Herramienta tool = new Herramienta(ETipoMaterial.Diamante);

            //Assert
            Assert.IsTrue(inv.AgregarHerramienta(tool));
        }

    }
}
