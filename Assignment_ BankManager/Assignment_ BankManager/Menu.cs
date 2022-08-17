using Assignment_BankManager;

namespace Assignment__BankManager
{
    public class Menu
    {
        Function _func;
        public Menu(Function func)
        {
            _func = func;
        }

        List<Account> Accounts = new();
        readonly Account instance = new();
        public List<Account> GetAll()
        {
            return Accounts;
        }

        public Account Add(Account instance)
        {
            Accounts.Add(instance);
            instance.Id = Accounts.Count;
            return instance;
        }

        public void AddAccount()
        {
            Account client = Accounts.Add();
        }

        instance.Add("Joris Jonckers", 556644446645, 40.65M, Accountstate.Geldig);
        Account new Account("Joris Jonckers", 556644446645, 40.65M, Accountstate.Geldig);
        Account acc2 = new Account("Ylana Devroes", 556698456512, 20.24M, Accountstate.Geldig);
        Account acc3 = new Account("Maria Koekelberghs", 556691457356, 1542.3245M, Accountstate.Geldig);
        Account acc4 = new Account("Gerard Poets", 512945632132, 98532.4566M, Accountstate.Geldig);
        Account acc5 = new Account("Frederik Kombuis", 512973165412, 1524685.3246M, Accountstate.Geldig);
        Account acc6 = new Account("Alina Bodroux", 131365478984, 25358.2676M, Accountstate.Geblokkeerd);
        Account acc7 = new Account("Odrey Cudo", 131365478984, 25358.2676M, Accountstate.Geblokkeerd);


        Account[] arrayOfAccounts = new Account[1] { acc1, };
        
        public int LoadCustomer()
        {
            Console.WriteLine("Load the customer 1 to 7             EXIT = 9");
            var keuze = int.Parse(Console.ReadLine());
            switch (keuze)
            {
                case 1:
                    DisplayMainMenu(acc1);
                    return 1;
                case 2:
                    DisplayMainMenu(acc2);
                    return 2;
                case 3:
                    DisplayMainMenu(acc3);
                    return 3;
                case 4:
                    DisplayMainMenu(acc4);
                    return 4;
                case 5:
                    DisplayMainMenu(acc5);
                    return 5;
                case 6:
                    DisplayMainMenu(acc6);
                    return 6;
                case 7:
                    DisplayMainMenu(acc7);
                    return 7;
                case 9: return 9;
            }
            return 0;
        }

        private Account SelectReferral(Account choice)
        {
            Console.WriteLine($"Load the customer 1 to 7 . Now active Customer{choice.Naam}");
            var keuze = int.Parse(Console.ReadLine());
            switch (keuze)
            {
                case 1:
                    return acc1;
                    break;
                case 2:
                    return acc2;
                    break;
                case 3:
                    return acc3;
                    break;
                case 4:
                    return acc4;
                    break;
                case 5:
                    return acc5;
                    break;
                case 6:
                    return acc6;
                    break;
                case 7:
                    return acc7;
                    break;
                default:
                    return null;
                    break;
            }
        }
        public void DisplayMainMenu(Account choice)
        {
            Console.WriteLine("1. Vraag klant details 2. Geldafhaling 3. Overschrijving 4. Wijzig rekening status");
            int keuze = int.Parse(Console.ReadLine());
            switch (keuze)
            {
                case 1:
                    _func.GetBalance(choice);
                    return;
                case 2:
                    _func.WithdrawFunds(choice);
                    return;
                case 3:
                    var choice2 = SelectReferral(choice);
                    _func.PayInFunds(choice, choice2);
                    return;
                case 4:
                    _func.ChangeState(choice);
                    return;
                case 9:
                    break;
                default:
                    return;
            }
        }
    }
}
