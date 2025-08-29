
using minimal_api.Dominio.Enuns;

namespace minimalApi.DTOs;

public class AdministradorDTO
{
    public string Email { get; set; } = default!;
    public string Senha { get; set; } = default!;
    public Perfil? perfil { get; set; } = default!;
}
