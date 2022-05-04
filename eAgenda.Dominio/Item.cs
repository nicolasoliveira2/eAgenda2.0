namespace eAgenda.Dominio
{
    public class Item
    {
        public bool Concluido;
        public string Titulo;

        public override string ToString()
        {
            return Titulo;
        }

        public void Concluir()
        {
            Concluido = true;
        }

        internal void MarcarPendente()
        {
            Concluido = false;
        }
    }
}