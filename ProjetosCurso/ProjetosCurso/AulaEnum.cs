using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetosCurso.Entities;
using ProjetosCurso.Entities.Enums;


namespace ProjetosCurso
{
    class AulaEnum
    {

        static void Main(string[] args)
        {

            Order order = new Order
            {

                id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.Delivered


            };

            Console.WriteLine(order);


        }



    }
}


