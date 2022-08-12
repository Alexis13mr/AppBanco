using System;

namespace AppBanco
{
    class Program
    {
        string[,] list = new string [3,2];
        int opmov=5, total=0;
        static void Main(string[] args)
        {
            Program st = new Program();
            st.start();
            while (st.opmov!=0)
            {
                st.Mov();
            }
            
            
            
        }
        public void start()
        {
            Console.WriteLine("Ingresa nombre y saldo de los clientes");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Cliente #"+(i+1)+": ");
                list[i, 0] = Console.ReadLine();
                Console.Write("Saldo: ");
                list[i, 1] = Console.ReadLine();
                Console.WriteLine();
            }
        }

        public void Mov()
        {
            int client, valor;
            Console.WriteLine("Seleccione el numero según la operación que desee realiza:");
            Console.WriteLine("1 Consignar");
            Console.WriteLine("2 Retirar");
            Console.WriteLine("3 Ver estado de cuenta");
            Console.WriteLine("0 Salir");
            opmov = int.Parse(Console.ReadLine());
            try
            {
                switch (opmov)
                {
                    case 1:
                        client =acount();
                        Console.WriteLine("El cliente "+list[client,0]+" tiene: " + list[client, 1] +". Cuanto desea consignar?");
                        valor = int.Parse(Console.ReadLine());
                        if (valor > 0)
                        {
                            list[client, 1] = (int.Parse(list[client, 1]) + valor).ToString();
                        }
                        else Console.WriteLine("Valor incorrecto");
                        Console.WriteLine("El nuevo saldo de " + list[client, 0] + " es de: " + list[client, 1] + ".");
                        Console.ReadKey();
                        break;
                    case 2:
                        
                        client = acount();
                        Console.WriteLine("Retirar");
                        Console.WriteLine("El cliente " + list[client, 0] + " tiene: " + list[client, 1] + ". Cuanto desea retirar?");
                        valor = int.Parse(Console.ReadLine());
                        if (valor <= int.Parse(list[client, 1]))
                        {
                            list[client, 1] = (int.Parse(list[client, 1]) - valor).ToString();
                        }
                        else Console.WriteLine("Valor incorrecto");
                        Console.WriteLine("El nuevo saldo de " + list[client, 0] + " es de: " + list[client, 1] + ".");
                        Console.ReadKey();
                        break;
                    case 3:
                        total = 0;
                        for (int i = 0; i < 3; i++)
                        {
                            total = total+ int.Parse(list[i, 1]);
                        }
                        Console.WriteLine("El saldo total es de "+total);
                        Console.ReadKey();
                        break;
                    case 0:

                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Seleccione un numero entre el 0 y el 3");                
            }            
        }
        public int acount()
        {
            int num = 4;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Seleccione "+(i+1)+" para ingresar a la cuenta de "+list[i,0]);
            }
            num = int.Parse(Console.ReadLine()) - 1;
            return num;
        }
    }
}
