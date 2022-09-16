using MyFirstAPI.Model;
using System.Collections.Generic;

namespace MyFirstAPI.Repository
{
    public interface IPersonRepository : IRepository<Person>
    {
        Person Disable(long id);
        List<Person> FindByName(string firstName, string secondName);
    }
}
