namespace QuaseTresLanches
{
    public class Pratos
    {
        
        public string  Nome { get; set; }
        

        public Pratos(string nome)
        {
            Nome=nome;
           
        }

        public virtual float Opcional()
        {
            return 0;   
        }
    }
}