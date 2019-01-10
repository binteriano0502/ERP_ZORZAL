﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ERP_GMEDINA.Models
{
    [MetadataType(typeof(BodegaDetalleMetaData))]
    public partial class tbBodegaDetalle
    {
    }


    public class BodegaDetalleMetaData
    {
        [Display(Name = "Número Detalle")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public int bodd_Id { get; set; }

        [Display(Name = "Producto")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public string prod_Codigo { get; set; }

        [Display(Name = "Número Bodega")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public int bod_Id { get; set; }

        [Display(Name = " Cantidad Mínima ")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public decimal bodd_CantidadMinima { get; set; }

        [Display(Name = " Cantidad Máxima ")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public decimal bodd_CantidadMaxima { get; set; }

        [Display(Name = " Cantidad Existente ")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public decimal bodd_CantidadExistente { get; set; }

        [Display(Name = "Punto Reorden ")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public decimal bodd_PuntoReorden { get; set; }

        //[Display(Name = "Creado Por")]
        ////[Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        //public int bodd_UsuarioCrea { get; set; }

        //[Display(Name = "Creado el")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        //public System.DateTime bodd_FechaCrea { get; set; }


        //[Display(Name = "Modificado por")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        //public Nullable<int> bodd_UsuarioModifica { get; set; }

        //[Display(Name = "Modificado el")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        //public Nullable<System.DateTime> bodd_FechaModifica { get; set; }


        [Display(Name = " Costo ")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public decimal bodd_Costo { get; set; }

        [Display(Name = " Costo Promedio ")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public decimal bodd_CostoPromedio { get; set; }

        [Display(Name = "Bodega")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public virtual tbBodega tbBodega { get; set; }

        [Display(Name = "Producto")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public virtual tbProducto tbProducto { get; set; }
    }
}