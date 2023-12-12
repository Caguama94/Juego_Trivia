using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace JuegoTrivia.Entities
{
    public class Preguntas
    {
        public string Pregunta { get; set; }
        public string OpcionA { get; set; }
        public string OpcionB { get; set; }
        public string OpcionC { get; set; }
        public string OpcionD { get; set; }
        public string OpcionCorrecta { get; set; }
        public bool YaSePregunto { get; set; }
        public string OpcionJugador { get; set; }
        public Preguntas(string Pregunta, string OpcionA, string OpcionB, string OpcionC, string OpcionD, string OpcionCorrecta, string OpcionJugador, bool YaSePregunto)
        {
            this.Pregunta = Pregunta;
            this.OpcionA = OpcionA;
            this.OpcionB = OpcionB;
            this.OpcionC = OpcionC;
            this.OpcionD = OpcionD;
            this.OpcionCorrecta = OpcionCorrecta;
            this.OpcionJugador = OpcionJugador;
            this.YaSePregunto = YaSePregunto;
        }
        public virtual string FormarPreguntaConComodin()
        { return ""; }
        public virtual string FormarPreguntaSinComodin()
        {
            return $"";
        }
        public virtual string FormarPreguntaSegundoIntento()
        {
            return $"";
        }
        public virtual string FormarPreguntaComodin()
        {
            return $"";
        }
        public virtual string SwitchRespuesta(string OpcionJugador)
        {
            return $"";
        }
        public virtual string Acertaste()
        {
            return $"";
        }
        public virtual string SegundoIntento()
        {
            return $"";
        }
    }
}
