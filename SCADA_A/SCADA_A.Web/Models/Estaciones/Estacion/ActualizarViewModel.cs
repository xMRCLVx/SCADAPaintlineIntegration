﻿using System.ComponentModel.DataAnnotations;

namespace SCADA_A.Web.Models.Estaciones.Estacion
{
    public class ActualizarViewModel
    {
        [Required]
        [StringLength(15, MinimumLength = 4, ErrorMessage = "El id de la estación debe ser de 4 a 15 caracteres")]
        public string idEstacion { get; set; }
        [Required]
        public int idLinea { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre de la estación debe ser de 3 a 50 caracteres")]
        public string Nombre { get; set; }
        public string SecuenciaPos { get; set; }
        public int TiempoCicloMedio_ms { get; set; }
    }
}
