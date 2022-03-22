/*sistema controla Pedidos, todos pedidos precisa saber:
       - nome do cliente
       - Pratos que ele pediu
       - calcular o valor e realizar o pagamento
       - recebe valor e calcula troco se necessário*/
namespace QuaseTresLanches
{
    public class Pedidos
    {
      public string Cliente { get; set; }
      public Pratos[] Pratos { get; set; }

      public Pedidos(string cliente, Pratos[] pratos)
      {    
        Cliente=cliente;
        Pratos=pratos;
      }
        
      public float Conta(int cod)
      {
        float total=0;
        bool adicionarPrato=true;
        for( var contador=0; adicionarPrato == false; contador++)
        {
          total= total+(Pratos[cod].Opcional());
          Con
          return total;
        }
      }  
      
    }
}