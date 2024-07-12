public class MedidasDePeso {
    public double Peso { get; set; }
    public DateTime Data { get; set; }
}
/////////////////////////////////////////////
public class MedidasDeAltura {
    public double Altura { get; set; }
    public DateTime Data { get; set; }
}
//////////////////////////////////////////////
public class Usuario {
    public string Nome { get; set; }
    public List<MedidasDePeso> Pesos { get; set; }
    public List<MedidasDeAltura> Alturas { get; set; }
    public double Imc { get; set; }
}
////////////////////////////////////////////////

public class BdUsuario {
    private List<Usuario> usuarios;
    public BdUsuario() {
        usuarios = new List<Usuario>();
    }
    public void AdicionarUsuario(Usuario usuario) {
        usuarios.Add(usuario);
    }
    public Usuario ObterUsuarioPorNome(string nome) {
        return usuarios.FirstOrDefault(u => u.Nome == nome);
    }
    public void AtualizarUsuario(Usuario usuario) {
        var usuarioExistente = ObterUsuarioPorNome(usuario.Nome);
        if (usuarioExistente != null) {
            usuarios.Remove(usuarioExistente);
            usuarios.Add(usuario);
        }
    }
    public void RemoverUsuario(string nome) {
        var usuarioExistente = ObterUsuarioPorNome(nome);
        if (usuarioExistente != null) {
            usuarios.Remove(usuarioExistente);
        }
    }
    public List<Usuario> ObterTodosUsuarios() {
        return usuarios;
    }
    public double CalcularImc(Usuario usuario) {
        var peso = usuario.Pesos.LastOrDefault()?.Peso ?? 0;
        var altura = usuario.Alturas.LastOrDefault()?.Altura ?? 0;
        return peso / (altura * altura);
    }
    public void AtualizarImc(Usuario usuario) {
        usuario.Imc = CalcularImc(usuario);
    }
    public Usuario ObterUsuarioComImcMaximo() {
        return usuarios.OrderByDescending(u => u.Imc).FirstOrDefault();
    }
    public Usuario ObterUsuarioComImcMinimo() {
        return usuarios.OrderBy(u => u.Imc).FirstOrDefault();
    }
    public Usuario ObterUsuarioComMenosMedidas() {
        return usuarios.OrderBy(u => u.Pesos.Count + u.Alturas.Count).FirstOrDefault();
    }
    public Usuario ObterUsuarioComMaisMedidas() {
        return usuarios.OrderByDescending(u => u.Pesos.Count + u.Alturas.Count).FirstOrDefault();
    }
    public List<Usuario> ObterUsuariosOrdenadosPorImc() {
        return usuarios.OrderByDescending(u => u.Imc).ToList();
    }
    public List<Usuario> ObterUsuariosOrdenadosPorNome() {
        return usuarios.OrderBy(u => u.Nome).ToList();
    }
}

