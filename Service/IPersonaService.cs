using MudBlazorTemplates4.Models;

namespace MudBlazorTemplates4.Service
{
    public interface IPersonaService
    {
        public Persona Save(Persona oPersona);
        public Persona Update(Persona oPersona);

        public Persona Get(int personaId);

        public List<Persona> Gets();

        public string Delete(int personaId);

    }
}
