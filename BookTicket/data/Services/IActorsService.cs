using BookTicket.Models;

namespace BookTicket.data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAll();
        Actor GetById(int id);
        void Add(Actor actor);
        Actor Update(int id, Actor newActor);
        Actor Delete(int id);
    }
}
