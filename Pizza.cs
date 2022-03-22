namespace QuaseTresLanches
{
    public class Pizza : Pratos
    {
        public Pizza(string nome): base(nome)
        {

        }
       public override float Opcional()
       {
           bool correct=true;
           do
           {
           Console.WriteLine("Com borda ou sem borda? \n ( 1 )....(SIM)    ( 2 )....(NÃO)");
           int opcao=int.Parse (Console.ReadLine());
           if (opcao == 1)
           {
               correct=true;
               return 30;
           }

           else if (opcao == 2)
           {
               correct=true;
               return 40;
           }

           else 
           {
               correct=false;
               Console.WriteLine("Não foi digitado uma opção válida, digite novamente.");
               return 0;
           }

           } 
           while( correct == true);
       } 
    }
}