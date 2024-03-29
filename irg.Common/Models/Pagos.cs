﻿
namespace irg.Common.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Pagos
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string Clave_Instituto { get; set; }
        [Required]
        public string Folio { get; set; }
        [Required]
        public int Matricula { get; set; }
        [Required]
        public string Clave_Concepto { get; set; }
        public string CC { get; set; }
        public string ME { get; set; }
        public string CV { get; set; }
        public string LI { get; set; }
        public string NA { get; set; }
        public string Detalles { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Costo { get; set; }
        public decimal Recargos { get; set; }
        public decimal Pagado { get; set; }
        public decimal Total_Calculado { get; set; }
        [Required]
        public string Usuario { get; set; }
        public Int16 Ano { get; set; }
        public byte No_Cuatrimestre { get; set; }
        public string F_Bancario { get; set; }
        public Int16 Cancelado { get; set; }
        public Int16 H_Clase { get; set; }
        public string Detalle_Descuento { get; set; }
        [Required]
        public string Fecha_Banco { get; set; }
        [Required]
        public string Forma_Pago { get; set; }
        [Required]
        public string Estatus { get; set; }
        public string Factura { get; set; }

        public override string ToString()
        {
            return $"{Matricula}{Detalles}";
        }
    }

}

