//criar um sistema para abertura de pedidos e pagamentos de uma lanchonete


//lanchonete possui 3 itens de venda: pizzas, lanches e salgadinhos. 

//pedidos serão criados da classe Main

    /*sistema controla Pedidos, todos pedidos precisa saber:
       - nome do cliente
       - Pratos que ele pediu
       - calcular o valor e realizar o pagamento
       - recebe valor e calcula troco se necessário*/


    /*Todo prato deverá ter Recheio e Valor, o comportamento de calcular seu Preço:(classes hereditarias)
            - Pizza tem o valor de 30 reais e +10 caso tenha "BordaRecheada"
            - Salgadinho varia entre "Assado" e "Frito", Valor de 7 reais para Frito e 6 para Assados
            - Lanche Simples 30 reais e +50% se for duplo*/

            namespace QuaseTresLanches
            {
                public class Program
                {
                    static void Main(string[] args)
                    {

                        var numeros = new List<int>();
                        var numerosMaisDez = new List<int>();
                        var strings = new List<string>();
                        for(var contador = 0; contador<10; contador++)
                        {
                            numeros.Add(contador);
                            numeros.Add(contador+10);
                            numeros.Add(contador.ToString());
                        }
                        //add uma lista dentro de outra
                        numeros.AddRange(numerosMaisDez);
                        //remover esse valor de uma lista independente da pocisão
                        numeros.Remove(5);
                        //remover valor de acordo com a posição
                        numeros.RemoveAt(5);
                        //remover todos item de acordo com a expressão
                        numero.RemoveAll(lixo => lixo != 3);
                        //
                        numeros.RemoveRange(0, 5)


                        Console.WriteLine("Qual o nome do cliente?");
                        string cliente=Console.ReadLine();
                        
                        bool addPrato=true;
                        for (var contador = 0; addPrato == false; contador++)
                        {
                            Console.WriteLine("    DIGITE O NÚMERO DO PRATO \n");
                            Console.WriteLine("( 1 )......Pizza");
                            Console.WriteLine("( 2 )......Salgadinho");
                            Console.WriteLine("( 3 )......Lanche Simples \n");
                            int cod =int.Parse (Console.ReadLine());
                            Pratos[] prato = new Pratos[3];
                            prato[0]= new Pizza("Pizza");
                            prato[1]= new Salgadinho("Salgadinho");
                            prato[2]= new Lanche("Pizza");
                            prato[cod].Opcional();
                            float total = total + prato[cod].Opcional();

                            Console.WriteLine("Adicionar algum prato?");
                            Console.WriteLine("( 1 )......Sim");
                            Console.WriteLine("( 2 )......NÃO");
                            int confirm = int.Parse(Console.ReadLine());

                             if (confirm == 1)
                            {
                                addPrato=true;
                            }

                            else if (confirm == 2)
                            {
                                addPrato=false;
                            }

                            else 
                            {
                                addPrato=true;
                                Console.WriteLine("Não foi digitado uma opção válida, digite novamente.");
                            }
                        }    
                        
                        
                        
                        
                        Pedidos pedido = new Pedidos(cliente, prato);
                         total = pedido.Conta(cod);
                        
                           
                        



                    }
                }
            }

           


