using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer();
            Console.Write("Adı:");
            gamer.FirstName = Console.ReadLine();
            Console.Write("Soyadı:");
            gamer.LastName = Console.ReadLine();
            Console.Write("T.c No:");
            gamer.IdentityNumber = long.Parse(Console.ReadLine());
            Console.Write("Doğum Yılı:");
            gamer.BirthYear = int.Parse(Console.ReadLine());

            UserValidationManager check = new UserValidationManager();
            

            if (check.Validate(gamer))
            {
                Console.WriteLine("Kayıt Bulundu");
            }
            else
            {
                Console.WriteLine("Böyle Bir Kayıt Bulunamadı");
            }

        }
    }
}
