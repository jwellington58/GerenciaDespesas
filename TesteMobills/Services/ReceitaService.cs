using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteMobills.Models;
using TesteMobills.Repositories;

namespace TesteMobills.Services
{
    public class ReceitaService
    {
        private readonly ReceitaRepository _repository;
        public ReceitaService(Context context)
        {
            this._repository = new ReceitaRepository(context);
        }
        public Receita GetById(int Id)
        {
            return this._repository.GetById(Id);
        }
        public IQueryable<Receita> GetAll()
        {
            return this._repository.GetAll();
        }
        public Receita Create(Receita entity)
        {
            return this._repository.Create(entity);
        }
        public void Delete(int id)
        {
            this._repository.Delete(id);
        }

        public void Update(Receita entity, int id)
        {
            this._repository.Update(entity, id);
        }
    }
}
