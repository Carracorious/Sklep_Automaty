using Sklep_z_Automatami_vendingowymi;

while (true)
{
    Console.WriteLine("1. Automaty\n" + "2. Magazyn\n" + "3. Zamówienia\n");
    string wybor = Console.ReadLine();
    switch (wybor)
    {
        case "1":
            {
                Console.WriteLine(
                    "1. Wypisz wszytkie automaty\n" +
                    "2. Wypisz automaty na gorące napoje\n" +
                    "3. Wypisz automaty na zimne napoje\n" +
                    "4. Wypisz automaty na przekąski\n" +
                    "5. Wypisz automaty na zdrową żywność\n");
                string wyborAutomaty = Console.ReadLine();
                switch (wyborAutomaty)
                {
                    case "1":
                        {
                            Automat automat = new Automat();
                            automat.getAutomatInfo();
                            break;
                        }
                    case "2":
                        {
                            AutomatGoraceNapoje automatGorace = new AutomatGoraceNapoje();
                            automatGorace.getHotAutomatInfo();
                            break;
                        }
                    case "3":
                        {
                            AutomatZimneNapoje automatZimne = new AutomatZimneNapoje();
                            automatZimne.getColdAutomatInfo();
                            break;
                        }
                    case "4":
                        {
                            AutomatPrzekaski automatPrzekaski = new AutomatPrzekaski();
                            automatPrzekaski.getSnackAutomatInfo();
                            break;
                        }
                    case "5":
                        {
                            AutomatZdrowa automatZdrowa = new AutomatZdrowa();
                            automatZdrowa.getHealthyAutomatInfo();
                            break;
                        }
                }
                break;
            }
        case "2":
            {
                Console.WriteLine(
                    "1. Stan magazynu\n" +
                    "2. Dodaj do magazynu\n" +
                    "3. Usuń z magazynu\n" );
                string magazynWybor = Console.ReadLine();
                Magazyn magazyn = new Magazyn();
                switch (magazynWybor)
                {
                    case "1":
                        {
                            magazyn.getAmmount();
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Aby dodać automat podaj nazwę automatu:");
                            string addMagazyn = Console.ReadLine();
                            magazyn.addAutomat(addMagazyn);
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("Aby usunąć automat podaj nazwę automatu: ");
                            string removeMagazyn = Console.ReadLine();
                            magazyn.removeAutomat(removeMagazyn);
                            break;
                        }
                    
                }
                break;
            }
        case "3":
            {
                Console.WriteLine(
                    "1. Pokaż zamówienia\n" +
                    "2. Doadaj zamówienie\n" +
                    "3. Usuń zamówienie\n");
                string zamowieniaWybor = Console.ReadLine();
                Zamowienia zamowienia = new Zamowienia();
                switch(zamowieniaWybor)
                {
                    case "1":
                        {
                            zamowienia.showZamowienia();
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Podaj imię i nazwisko klienta: ");
                            string clientAdd = Console.ReadLine();
                            Console.WriteLine("Podaj nazwę automatu: ");
                            string nameAdd = Console.ReadLine();
                            Console.WriteLine("Podaj ilość zamówionych automatów: ");
                            int quantityAdd = int.Parse(Console.ReadLine());
                            Console.WriteLine("Podaj datę zamówienia: ");
                            DateOnly dateAdd = DateOnly.Parse(Console.ReadLine());
                            zamowienia.addZamowienie(clientAdd, nameAdd, quantityAdd, dateAdd);
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("Podaj Imię i nazwisko klienta: ");
                            string clientRemove = Console.ReadLine();
                            Console.WriteLine("Podaj nazwę automatu: ");
                            string nameRemove = Console.ReadLine();
                            zamowienia.removeZamowiene(clientRemove, nameRemove);
                            break;
                        }
                }
            break;
            }
    }
}
