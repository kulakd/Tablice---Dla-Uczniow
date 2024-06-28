namespace Tablica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // zadanie 1
            //int user1 = 21;
            ////int user2 = 18;
            ////int user3 = 14;
            ////int user4 = 72;
            ////double srednia = (user1 + user2 + user3 + user4) / 4.0;
            //int[] users = new int[4] {21,18,14,72};
            //Console.WriteLine(user1);
            //Console.WriteLine(users[0]);
            //Console.WriteLine(users.Length);
            //Console.WriteLine(users.Average());
            ////Console.WriteLine(srednia);
            //Console.ReadKey();


            // zadanie 2
            //string[] biblioteka = new string[] 
            //{
            //    "Persona 5",
            //    "Overwatch 2",
            //    "Fire Emblem",
            //    "Mount&Blade",
            //    "Mass Effect 1",
            //    "Mass Effect 2",
            //    "Mass Effect 3",
            //    "TES 1",
            //    "TES 2",
            //    "TES 3",
            //    "TES 4",
            //    "TES 5",
            //    "Mega Man",
            //    "Sonic & Shadow Generation"
            //};
            //Console.WriteLine("Poniżej zanjdują się gry do wylosowania:");
            //for(int i = 0; i < biblioteka.Length; i++) 
            //{
            //    Console.WriteLine( i+1 + ". " + biblioteka[i]);
            //}
            //Random random = new Random();
            //int wylosowanaGra = random.Next(0, biblioteka.Length);
            //Console.WriteLine($"Wylosowana gra to : {biblioteka[wylosowanaGra]}");
            //zadanie 3

            string[] filmy = new string[8]
            {
                "Harry Potter 1",
                "Harry Potter 2",
                "Harry Potter 3",
                "Harry Potter 4",
                "Harry Potter 5",
                "Harry Potter 6",
                "Harry Potter 7 cz 1",
                "Harry Potter 7 cz 2"
            };
            string[] godziny = new string[4] { "10.00", "12.00", "14.00", "18.00" };
            string[] informacje = new string[7] { "Film", "Godzina", "Imie", "Nazwisko", "telefon", "Liczba biletow","Wiek" };
            string[] rezerwacje = new string[7];
            decimal cenaBiletu = 29.5m;
            Console.WriteLine("Witamy w panelu użytkownika rezerwacji seansu filmowego w kinie w Podlasie.");
            while (true)
            {
                Console.WriteLine("Wybierz numer filmu:");
                for(int i = 0; i < filmy.Length; i++) 
                {
                    Console.WriteLine($"{i+1}. {filmy[i]}");
                }
                int wyborFilmu = int.Parse(Console.ReadLine());
                if( wyborFilmu >= 0 && wyborFilmu < filmy.Length ) 
                {
                    rezerwacje[0] = filmy[wyborFilmu];
                }
                else
                {
                    Console.WriteLine("Wybrano zly numer, sprobuj jeszcze raz");
                    continue;
                }

                Console.WriteLine("Wybierz godzine seansu: ");
                for(int i = 0; i< godziny.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {godziny[i]}");
                }

                int wyborGodziny = int.Parse(Console.ReadLine());
                if (wyborGodziny >= 0 && wyborGodziny<godziny.Length)
                {
                    rezerwacje[1] = godziny[wyborGodziny];
                }
                else
                {
                    Console.WriteLine("Wybrano zly numer, sprobuj jeszcze raz");
                    continue;
                }
                Console.WriteLine("Uzupełnij swoje dane:");
                for(int i = 2; i< rezerwacje.Length; i++ )
                {
                    Console.WriteLine($"Podaj {informacje[i]}");
                    rezerwacje[i] = Console.ReadLine();
                }
                Console.WriteLine("DANE REZERWACJI");
                for(int i=0; i< rezerwacje.Length; i++ )
                {
                    Console.WriteLine($"{informacje[i]}: {rezerwacje[i]}");
                }
            }
        }
    }
}