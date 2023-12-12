using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace JuegoTrivia.Entities
{
    public class Jugador
    {
        public string Nombre { get; set; }
        public int Numero { get; set; }
        public int Comodines { get; set; }
        public int Puntuacion { get; set; }


        public Jugador(string Nombre, int Numero, int Comodines, int Puntuacion)
        {
            this.Nombre = Nombre;
            this.Numero = Numero;
            this.Comodines = Comodines;
            this.Puntuacion = Puntuacion;
        }
        public override string ToString()
        {
            return "[" + Nombre + "," + Numero + " , " + Comodines + " , " + Puntuacion + "]";
        }

        public virtual string UsarComodines()
        {
            
            return $"Tienes {Comodines} comodines" +$"\nUsaste 1 comodin" +$"\nTe quedan {Comodines = Comodines-1} comodines";
        }

        public virtual string Acierto3Puntos()
        {            
            return $"{Nombre} tenia {Puntuacion} puntos"+$"\nGano 3 puntos, dejandolo con un total de {Puntuacion=Puntuacion+3} puntos";
        }

        public virtual string Acierto1Punto()
        {
            return $"{Nombre} tenia {Puntuacion} puntos" + $"\nGano 1 punto, dejandolo con un total de {Puntuacion = Puntuacion + 1} puntos";
        }
    }
}

