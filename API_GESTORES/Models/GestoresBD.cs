using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_GESTORES.Models
{
    public class GestoresBD
    {

        [Key]
        private int _id;
        private string nombre;
        private int lanzamiento;
        private string desarrollador;

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Lanzamiento { get => lanzamiento; set => lanzamiento = value; }
        public string Desarrollador { get => desarrollador; set => desarrollador = value; }
    }
}
