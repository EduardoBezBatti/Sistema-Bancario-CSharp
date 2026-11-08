namespace SistemaBancario.Domain.Entities
{
    public class Usuario
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public Usuario(string nome, string email)
        {
            if(string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException("O nome e obrigatorio", nameof(nome));
            }

            Id = Guid.NewGuid();
            Nome = nome.Trim();
            Email = email;
        }
    }
}
