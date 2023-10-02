//addig kérjen be számot amig 5-el oszthatot nem kap majd nezze meg hogy 10 oszthato e

    
        int szam;

        while (true)
        {
            Console.Write("Kérem adjon meg egy számot: ");
            if (int.TryParse(Console.ReadLine(), out szam))
            {
                if (szam % 5 == 0)
                {
            Console.WriteLine("Oszthato 5-el");
                    if (szam % 10 == 0)
                    {
                        Console.WriteLine("A megadott szám osztható 10-zel is.");
                    }
                    else
                    {
                        Console.WriteLine("A megadott szám nem osztható 10-zel.");
                    }
                    break; 
                }
                else
                {
                    Console.WriteLine("A megadott szám nem osztható 5-tel.");
                }
            }
            else
            {
                Console.WriteLine("Hibás bemenet. Kérem adjon meg egy érvényes számot.");
            }
        }
