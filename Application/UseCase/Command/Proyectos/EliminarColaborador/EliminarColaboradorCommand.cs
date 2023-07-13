﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase.Command.Proyectos.EliminarColaborador
{
    public record EliminarColaboradorCommand : IRequest<Guid>
    {
        public Guid ProyectoId { get; set; }
        public Guid ColaboradorId { get; set; }
        public Guid EjecutorId { get; set; }

    }
}
