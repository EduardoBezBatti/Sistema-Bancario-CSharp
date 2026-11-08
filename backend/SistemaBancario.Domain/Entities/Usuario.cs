namespace SistemaBancario.Domain.Entities
{
    public class Usuario
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;

        public Usuario(string nome, string email)
        {
            if(string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException("O nome e obrigatorio", nameof(nome));
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                throw new ArgumentException("O email e obrigatorio",nameof(email));
            }

            Id = Guid.NewGuid();
            Nome = nome.Trim();
            Email = email.Trim();
        }
    }
}
