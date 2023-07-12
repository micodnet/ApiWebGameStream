using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_Model.Jeux_Repositories
{
    public class Jeux_Repository: IRepository<Jeux_Repository, int>
    {
        private string _repo;
        public Jeux_Repository(string repo)
        {
            _repo = repo;   
        }

        public int Count => throw new NotImplementedException();

        public Jeux_Repository Add(Jeux_Repository entity)
        {
            throw new NotImplementedException();
        }

        public Jeux_Repository Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Jeux_Repository> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Jeux_Repository> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public Jeux_Repository GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public Jeux_Repository Patch(Jeux_Repository entity)
        {
            throw new NotImplementedException();
        }

        public Jeux_Repository Put(Jeux_Repository entity)
        {
            throw new NotImplementedException();
        }

    }
}
