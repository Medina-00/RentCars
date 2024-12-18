﻿

using Core.Application.ViewModel.Vehiculo;

namespace Core.Application.ViewModel.Reserva
{
    public class SaveReservaViewModel
    {
        public string UsuarioId { get; set; }
        public int VehiculoId { get; set; } // Clave foránea

        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public double Latitud { get; set; }  // Ubicación del vehículo durante la reserva
        public double Longitud { get; set; } // Ubicación del vehículo durante la reserva
        public string Cedula { get; set; }

        public string NumeroLincencia { get; set; }
        public decimal PrecioTotal { get; set; }

        // Relación  con Vehiculos
        public List<VehiculoSelectListItem>? Vehiculos { get; set; }
    }
}
