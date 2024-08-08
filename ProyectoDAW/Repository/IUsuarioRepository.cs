using ProyectoDAW.Models;
using System.Threading.Tasks;

namespace ProyectoDAW.Repository
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<Usuario>> GetUsuarios();
        Task<Usuario> GetUsuarioById(int id);
        Task<Usuario> AddUsuario(Usuario usuario);
        Task<Usuario> UpdateUsuario(Usuario usuario);
        Task<Usuario> DeleteUsuario(int id);
    }
}
