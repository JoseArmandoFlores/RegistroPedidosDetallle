using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroPedidos.Models
{
    public class OrdenesDetalle
    {
        [Key]
        public int Id { get; set; }
        public int OrdenId { get; set; }
        public int Cantidad { get; set; }
        public int ProductoId { get; set; }
        public decimal Costo { get; set; }
        public OrdenesDetalle(int id, int ordenId, int cantidad, int productoId, decimal costo)
        {
            Id = id;
            OrdenId = ordenId;
            Cantidad = cantidad;
            ProductoId = productoId;
            Costo = costo;
        }
        public OrdenesDetalle()
        {
        }
    }
}

