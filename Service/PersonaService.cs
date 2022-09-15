using Microsoft.EntityFrameworkCore;
using MudBlazorTemplates4.Models;

namespace MudBlazorTemplates4.Service
{
    public class PersonaService : IPersonaService
    {

        DbTalMContext _dbTalMContext;
        public PersonaService(DbTalMContext dbTalMContext)
        {
            _dbTalMContext = dbTalMContext;
        }

      
        public string Delete(int personaId)
        {
            var persona = _dbTalMContext.Personas.FirstOrDefault(x => x.IdPersona == personaId);

            _dbTalMContext.Personas.Remove(persona);
            _dbTalMContext.SaveChanges();
            return "deleted Person";
        }

        public Persona Get(int personaId)
        {
            return _dbTalMContext.Personas.FirstOrDefault(x => x.IdPersona == personaId);
        }

        public List<Persona> Gets()
        {
            return _dbTalMContext.Personas.ToList();
        }

        public Persona Save(Persona oPersona)
        {
            _dbTalMContext.Personas.Add(oPersona);
            _dbTalMContext.SaveChanges();
            return this.Get(oPersona.IdPersona);
        }

        public Persona Update(Persona oPersona)
        {
            _dbTalMContext.Personas.Update(oPersona);
            _dbTalMContext.SaveChanges();
            return this.Get(oPersona.IdPersona);
        }
    }
}
