using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Marca
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public override string ToString() //sobreescribimos metodo ToString para que retorne el valor de la descripcion (string)
        {
            return Descripcion;
        }
    }

}
