using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoTrivia.Entities
{
    public class Ciencia : Preguntas
    {
        public Ciencia(string Pregunta, string OpcionA, string OpcionB, string OpcionC, string OpcionD, string OpcionCorrecta, string OpcionJugador, bool YaSePregunto) : base(Pregunta, OpcionA, OpcionB, OpcionC, OpcionD, OpcionCorrecta, OpcionJugador, YaSePregunto)
        {
        }
        public override string FormarPreguntaConComodin()
        { return $"\n{Pregunta}" + $"\n a ) {OpcionA}" + $"\n b ) {OpcionB}" + $"\n c ) {OpcionC}" + $"\n d ) {OpcionD}" + $"\n e ) Usar Comodín"; }
        public override string FormarPreguntaSinComodin()
        { return $"\n{Pregunta}" + $"\n a ) {OpcionA}" + $"\n b ) {OpcionB}" + $"\n c ) {OpcionC}" + $"\n d ) {OpcionD}"; }
        public override string FormarPreguntaSegundoIntento()
        {
            if (OpcionJugador == OpcionA)
            {
                return $"\n{Pregunta}" + $"\n b ) {OpcionB}" + $"\n c ) {OpcionC}" + $"\n d ) {OpcionD}";
            }
            else if (OpcionJugador == OpcionB)
            {
                return $"\n{Pregunta}" + $"\n a ) {OpcionA}" + $"\n c ) {OpcionC}" + $"\n d ) {OpcionD}";
            }
            else if (OpcionJugador == OpcionC)
            {
                return $"\n{Pregunta}" + $"\n a ) {OpcionA}" + $"\n b ) {OpcionB}" + $"\n d ) {OpcionD}";
            }
            else if (OpcionJugador == OpcionD)
            {
                return $"\n{Pregunta}" + $"\n a ) {OpcionA}" + $"\n b ) {OpcionB}" + $"\n c ) {OpcionC}";
            }
            else
            {
                return "";
            }
        }
        public override string FormarPreguntaComodin()
        {
            if (OpcionCorrecta == OpcionA)
            {
                return $"\n{Pregunta}" + $"\n a ) {OpcionA}" + $"\n c ) {OpcionC}" + $"\n d ) {OpcionD}";
            }
            else if (OpcionCorrecta == OpcionB)
            {
                return $"\n{Pregunta}" + $"\n a ) {OpcionA}" + $"\n b ) {OpcionB}" + $"\n d ) {OpcionD}";
            }
            else if (OpcionCorrecta == OpcionC)
            {
                return $"\n{Pregunta}" + $"\n b ) {OpcionB}" + $"\n c ) {OpcionC}" + $"\n d ) {OpcionD}";
            }
            else if (OpcionCorrecta == OpcionD)
            {
                return $"\n{Pregunta}" + $"\n a ) {OpcionA}" + $"\n b ) {OpcionB}" + $"\n d ) {OpcionD}";
            }
            else
            {
                return $"";
            }
        }
        public override string SwitchRespuesta(string OpcionJugador)
        {
            switch (OpcionJugador.ToLower())
            {
                case "a": OpcionJugador = OpcionA; return OpcionJugador; break;
                case "b": OpcionJugador = OpcionB; return OpcionJugador; break;
                case "c": OpcionJugador = OpcionC; return OpcionJugador; break;
                case "d": OpcionJugador = OpcionD; return OpcionJugador; break;
            }
            return OpcionJugador;
        }
        public override string Acertaste()
        {
            YaSePregunto = true;
            return $"Acertaste!!!\n La respuesta correcta era {OpcionCorrecta} y respondiste {OpcionJugador}";
        }
        public override string SegundoIntento()
        {
            return $"La respuesta seleccionada es incorrecta \n Tienes una segunda oportunidad";
        }
    }
}