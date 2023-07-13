﻿using Domain.Model.TiposProyectos;
using SharedKernel.Core;

namespace Domain.Repository.TiposTipoProyectos
{
    public interface ITipoProyectoRepository : IRepository<TipoProyecto, Guid>
    {
        Task UpdateAsync(TipoProyecto obj);
        Task RemoveAsync(TipoProyecto obj);
    }
}
