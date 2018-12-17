﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ERP_GMEDINA.Models
{
    [MetadataType(typeof(MonedasMetaData))]

    public partial class tbMoneda
    {

    }


    public class MonedasMetaData
    {
        [Display (Name ="Número")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public short mnda_Id { get; set; }


        [Display(Name = "Abreviatura")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public string mnda_Abreviatura { get; set; }


        [Display(Name = "Nombre")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public string mnda_Nombre { get; set; }


        [Display(Name = "Usuario Crea")]
        public int mnda_UsuarioCrea { get; set; }


        [Display(Name = "Fecha Crea")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy H:mm:ss tt}", ApplyFormatInEditMode = true)]
        public System.DateTime mnda_FechaCrea { get; set; }


        [Display(Name = "Usuario Modifica")]
        public Nullable<int> mnda_UsuarioModifica { get; set; }


        [Display(Name = "Fecha Modifica")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy H:mm:ss tt}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> mnda_FechaModifica { get; set; }
    }
}