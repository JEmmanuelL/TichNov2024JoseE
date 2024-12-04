﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOWebForms.Entidades
{
    internal interface ICRUD
    {
        List<EstatusAlumno> Consultar();

        EstatusAlumno Consultar(int id);

        int Agregar(EstatusAlumno DataEstatus);

        void Actualizar(EstatusAlumno DataEstatus);

        void Eliminar(int id);
    }
}
