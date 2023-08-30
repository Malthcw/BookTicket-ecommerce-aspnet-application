using BookTicket.Models;
using Microsoft.EntityFrameworkCore;

namespace BookTicket.data.Services
{
    public class ActorsServices : IActorsService
    {

        private readonly AppDbContext _context;

        public ActorsServices(AppDbContext context)
        {
            _context = context;
        }


        public void Add(Actor actor)
        {
            _context.Actor.Add(actor);
            _context.SaveChanges();
        }

        public Actor Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            var result = await _context.Actor.ToListAsync();
            return result;
        }

        public Actor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Actor Update(int id, Actor newActor)
        {
            throw new NotImplementedException();
        }
    }
}
