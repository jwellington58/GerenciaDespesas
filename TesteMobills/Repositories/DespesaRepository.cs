using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteMobills.Models;

namespace TesteMobills.Repositories
{
    public class DespesaRepository
    {
        private readonly Context _context;

        public DespesaRepository(Context context)
        {
            this._context = context;
        }

        public Despesa GetById (int Id)
        {
            return this._context.Despesa.Find(Id);
        }

    }
}
