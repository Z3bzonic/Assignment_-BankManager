using Assignment__BankManager;
using Assignment_BankManager;

internal class Program
{
    /// <summary>
    /// BankManager
//    Ontwerp een klasse Account die minstens een Naamveld, bedrag en rekeningnummer bevat.Voorzie 3 methoden:

//WithdrawFunds: bepaald bedrag wordt van rekening verwijderd
//PayInFunds: bepaald bedrag(als parameter) wordt op de rekening gezet
//GetBalance: het totale bedrag op de rekening wordt teruggegeven

//Pas de WithdrawFunds methode aan zodat als returntype het bedrag(int) wordt teruggegeven.Indien het gevraagde bedrag meer dan de balance is dan geef je al het geld terug dat nog op de rekening staat en toon je in de console dat niet al het geld kon worden gegeven.

//Maak 2 instanties van het type Account aan en toon aan dat je geld van de ene account aan de andere kunt geven, als volgt:

//BankAccount rekening1 = new BankAccount();
//    BankAccount rekening2 = new BankAccount();
//    Voeg aan de Account-klasse een private field toe zijnde van het type accountState dat een enumeratie bevat.De account kan in volgende states zijn “Geldig”, “Geblokkeerd”). Maak een bijhorende publieke Methode waarmee je de account van state kunt veranderen.Deze methode(noem ze ChangeState) vereist één parameter van het type accountState natuurlijk.
//    Indien een persoon geld van of naar een Geblokkeerde rekening wil sturen dan zal er een error op het scherm verschijnen.


//    Test je klasse.

//    Nieuwe klant aanmaken (max 10)
//Status van bestaande klant tonen
//Geld op een bepaald account zetten
//Geld van een bepaald account afhalen
//Geld tussen 2 accounts overschrijven
//Voorzie extra functionaliteit naar keuze.
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
        Function func = new();
        Menu menu = new(func);
        Account account = new(menu);

        int exitcode = 0;
        while (exitcode != 9)
        {
            Console.Clear();
            exitcode = menu.LoadCustomer();
        }
    }
}