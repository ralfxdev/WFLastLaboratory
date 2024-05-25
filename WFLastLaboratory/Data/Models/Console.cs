using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFLastLaboratory.Data.Models
{
    internal class Console
    {
        public int IdConsola { get; set; }
        public string NombreConsola { get; set; }
        public string Compania { get; set; }
        public int AnioLanzamiento { get; set; }
        public byte Generacion { get; set; }

        public Console(int idConsola, string nombreConsola, string compania, int anioLanzamiento, byte generacion)
        {
            IdConsola = idConsola;
            NombreConsola = nombreConsola;
            Compania = compania;
            AnioLanzamiento = anioLanzamiento;
            Generacion = generacion;
        }
    }
}
