using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteMobills.Models;
using TesteMobills.Repositories;

namespace TesteMobills.Services
{
    public class DespesaService
    {
        private readonly DespesaRepository _repository;
        public DespesaService(Context context)
        {
            this._repository = new DespesaRepository(context);
        }
        public Despesa GetById(int Id)
        {
            return this._repository.GetById(Id);
        }
        public IQueryable<Despesa> GetAll()
        {
            return this._repository.GetAll();
        }
        public Despesa Create(Despesa entity)
        {
            return this._repository.Create(entity);
        }
        public void Delete(int id)
        {
            this._repository.Delete(id);
        }

        public void Update(Despesa entity, int id)
        {
            this._repository.Update(entity, id);
        }
    }
}
