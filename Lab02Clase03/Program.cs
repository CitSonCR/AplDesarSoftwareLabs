using System;

namespace Lab02Clase03
{
    class Program
    {
        static void Main(string[] args)
        {
            bool seguir = true;
            Debito debito = new Debito(123,100000);
            Credito credito = new Credito(456,0);
            do
            {
                Console.WriteLine("Elija la cuenta: (D / C) ");
                string cuenta = Console.ReadLine();

                Console.WriteLine("Elija el monto: ");
                decimal monto = Convert.ToDecimal(Console.ReadLine());

                if (cuenta.ToUpper().Equals("D"))
                {
                    Console.WriteLine(debito.GetData());
                    if (debito.Vender(monto) < decimal.Zero)
                    {
                        Console.WriteLine("No se puede restar el monto en la cuenta");
                    }                    
                    Console.WriteLine(debito.GetData());
                }
                else
                {
                    Console.WriteLine(credito.GetData());
                    credito.Vender(monto);
                    Console.WriteLine(credito.GetData());
                }


                Console.WriteLine("Continuar comprando? (Y/N) ");
                string x = Console.ReadLine();
                seguir = x.ToUpper().Equals("Y") ? true : false;
            } while (seguir);
            
        }
    }
}
