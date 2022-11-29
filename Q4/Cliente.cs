namespace Q4
{
    public class Cliente
    {
        public string CPF { get; private set; }
        public string Nome { get; private set; }

        public Cliente(string cpf, string nome)
        {
            CPF = cpf;
            Nome = nome;
        }

        public override bool Equals(object obj)
        {
            return obj is Cliente c &&
                CPF.Equals(c.CPF);
        }

        public override int GetHashCode()
        {
            int hash = CPF == null ? 0 : CPF.GetHashCode();
            return hash;
        }
    }
}
