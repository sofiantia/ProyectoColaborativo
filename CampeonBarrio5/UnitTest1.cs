using CampeonDeBarrio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebasUnitarias
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Jugador[] arregloJugadores = new Jugador[5]
            {   new Jugador {Nombre = "Juan", Campañas = 20, Puntos = 300 },
                new Jugador {Nombre = "sofia", Campañas = 10, Puntos = 200 },
                new Jugador {Nombre = "Andres", Campañas = 5, Puntos = 400 },
                new Jugador {Nombre= "Mateo", Campañas= 4, Puntos = 400 },
                new Jugador {Nombre= "Angela", Campañas = 2, Puntos = 100}
            };

            int Ganador = 1;
            


            //Act
            Jugador[] Ganadoractual = Program.IdentificaCampeon(arregloJugadores);


            //Asser
            Assert.AreEqual(Ganador, Ganadoractual.Length);

        }

        
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            Jugador[] arregloJugadores = new Jugador[5]
            {   new Jugador {Nombre = "Juan", Campañas = 20, Puntos = 300 },
                new Jugador {Nombre = "sofia", Campañas = 5, Puntos = 400 },
                new Jugador {Nombre = "Andres", Campañas = 0, Puntos = 0 },
                new Jugador {Nombre = "Mateo", Campañas = 5, Puntos = 400},
                new Jugador {Nombre = "Angela", Campañas = 2, Puntos = 160}
            };

            int empatados = 3;



            //Act
            Jugador[] empatadosreal = Program.IdentificaCampeon(arregloJugadores);


            //Asser
            Assert.AreEqual(empatados, empatadosreal.Length);


        }
        
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            Jugador[] arregloJugadores = new Jugador[5]
            {   new Jugador {Nombre = "Juan", Campañas = 1, Puntos = 200 },
                new Jugador {Nombre = "sofia", Campañas = 2, Puntos = 200 },
                new Jugador {Nombre = "Andres", Campañas = 3, Puntos = 200 },
                new Jugador {Nombre = "Mateo", Campañas = 4, Puntos = 200},
                new Jugador {Nombre = "Angela", Campañas = 5, Puntos = 200}
            };

            Jugador Campeonesperado = arregloJugadores[0];

            //Act
            Jugador[] Campeonreal = Program.IdentificaCampeon(arregloJugadores);
            


            //Asser
            Assert.AreEqual(Campeonesperado, Campeonreal[0]);


        }

    }
}
