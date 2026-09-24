using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace incapsulare_teorie
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Console.WriteLine("=============test========================");

            Useri();
        }

        static void Useri()
        {
            User u1 = new User();
            u1.age = 25;
            u1.email = "andrei.popescu@gmail.com";
            u1.valid = true;
            u1.password = "Andrei99!";
            u1.username = "andrei_pop";
            u1.phoneNr = "0722123456";

            User u2 = new User();
            u2.age = 31;
            u2.email = "elena.ionescu@yahoo.com";
            u2.valid = true;
            u2.password = "ElenaSecure20";
            u2.username = "elena_io";
            u2.phoneNr = "0731987654";

            User u3 = new User();
            u3.age = 19;
            u3.email = "vlad.marcu@outlook.com";
            u3.valid = false;
            u3.password = "vladmarcu123";
            u3.username = "vlad_m";
            u3.phoneNr = "0745112233";

            User u4 = new User();
            u4.age = 42;
            u4.email = "raluca.constantin@gmail.com";
            u4.valid = true;
            u4.password = "Ralu*2026";
            u4.username = "ralu_c";
            u4.phoneNr = "0756445566";

            User u5 = new User();
            u5.age = 28;
            u5.email = "cosmin.radu@gmail.com";
            u5.valid = true;
            u5.password = "cosminPass!";
            u5.username = "cosmin_radu";
            u5.phoneNr = "0767889900";

            User u6 = new User();
            u6.age = 22;
            u6.email = "anamaria.stan@yahoo.com";
            u6.valid = true;
            u6.password = "ana_maria_99";
            u6.username = "ana_stan";
            u6.phoneNr = "0721334455";

            User u7 = new User();
            u7.age = 50;
            u7.email = "marian.dumitru@gmail.com";
            u7.valid = false;
            u7.password = "marianD76";
            u7.username = "marian_d";
            u7.phoneNr = "0732556677";

            User u8 = new User();
            u8.age = 16;
            u8.email = "alex.neagu@outlook.com";
            u8.valid = true;
            u8.password = "AlexGaming!!";
            u8.username = "AlexGamer";
            u8.phoneNr = "0743778899";

            User u9 = new User();
            u9.age = 35;
            u9.email = "cristina.vlad@gmail.com";
            u9.valid = true;
            u9.password = "CrisVlad85";
            u9.username = "cristina_v";
            u9.phoneNr = "0754114477";

            User u10 = new User();
            u10.age = 27;
            u10.email = "stefan.badea@yahoo.com";
            u10.valid = true;
            u10.password = "stefanB_99";
            u10.username = "stefan_b";
            u10.phoneNr = "0765225588";

            List<User> users = new List<User>();
            users.Add(u1);
            users.Add(u2);
            users.Add(u3);
            users.Add(u4);
            users.Add(u5);
            users.Add(u6);
            users.Add(u7);
            users.Add(u8);
            users.Add(u9);
            users.Add(u10);

            //afisam toti userii in consola

            Console.WriteLine("=============afisam toti userii==============");
            for (int i = 0; i < users.Count; i++)
            {

                Console.WriteLine(users[i].username);

            }


        }
    }
}
