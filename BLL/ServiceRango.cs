﻿using DAL.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public  class ServiceRango
    {
        private readonly DBRango dBRango;
        public ServiceRango(DBRango dBRango)
        {
            this.dBRango = dBRango;
        }
        public async Task<List<Rango>> Leer()
        {
            return await dBRango.Leer();
        }
        public async Task<Rango> Buscar(int id)
        {
            return await dBRango.Buscar(id);
        }
    }
}
