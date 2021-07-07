﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practico01WF.Entidades;

namespace Practico01WF.Datos.Repositorios.Facades
{
    public interface IRepositorioPlanta
    {
        List<Planta> GetLista(int registros, int pagina);
        Planta GetPlantaPorId(int id);
        void Guardar(Planta planta);
        bool Existe(Planta planta);
        int GetCantidad();
        void Borrar(int plantaId);
    }
}
