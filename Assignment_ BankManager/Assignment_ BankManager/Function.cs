using Assignment__BankManager;

namespace Assignment_BankManager
{
    public class Function
    {

        public void WithdrawFunds(Account acc)
        {
            Console.WriteLine("Enter the withdrawal amount");
            var draw = decimal.Parse(Console.ReadLine());
            if (((acc.Bedrag - draw) < 0))
            {
                Console.WriteLine($"U heeft {acc.Bedrag}€ afgehaald, u had op balans echter {acc.Bedrag - draw}€ te weinig om het gevraagde bedrag te krijgen.");
                acc.Bedrag -= acc.Bedrag;
                DisplayHaltMessage();
            }
            else
            {
                acc.Bedrag -= draw;
                Console.WriteLine($"U heeft {draw}€ afgehaald");
                DisplayHaltMessage();
            }
        }

        public void PayInFunds(Account acc, Account acc2)
        {
            var canTransfer = CheckState(acc, acc2);
            if (canTransfer)
            {
                Console.WriteLine("Enter the transfer amount");
                var draw = decimal.Parse(Console.ReadLine());
                if (((acc.Bedrag - draw) < 0))
                {
                    Console.WriteLine($"U heeft {acc.Bedrag}€ op de balans, {acc.Bedrag - draw}€ te weinig om het gevraagde bedrag over te schrijven.");
                    DisplayHaltMessage();
                }
                else
                {
                    acc.Bedrag -= draw;
                    acc2.Bedrag += draw;
                    if (Object.Equals(acc,acc2))
                    {
                        Console.WriteLine(jester);
                        DisplayHaltMessage();
                    }
                    else
                    {
                        Console.WriteLine($"U heeft {draw}€ overgemaakt");
                        DisplayHaltMessage();
                    }
                }
            }
        }

        public void GetBalance(Account acc)
        {
            Console.WriteLine($"Naam:    {acc.Naam}");
            Console.WriteLine($"Bedrag:  {acc.Bedrag}");
            Console.WriteLine($"Rekening:{acc.Rekeningnummer}");
            Console.WriteLine($"Status:  {acc.Accountstate}");
            DisplayHaltMessage();
        }
        public void ChangeState(Account acc)
        {
            if (acc.Accountstate == Accountstate.Geblokkeerd)
            {
                acc.Accountstate = Accountstate.Geldig;
            }
            else
            {
                acc.Accountstate = Accountstate.Geblokkeerd;
            }
            Console.WriteLine($"Uw account is nu {acc.Accountstate}");
            DisplayHaltMessage();
        }

        private bool CheckState(Account acc, Account acc2)
        {
            if (acc.Accountstate == Accountstate.Geblokkeerd)
            {
                Console.WriteLine($"U kan niet overmaken. Uw account is {acc.Accountstate}");
                DisplayHaltMessage();
                return false;
            }
            else if (acc2.Accountstate == Accountstate.Geblokkeerd)
            {
                Console.WriteLine($"De ontvanger kan geen betaling aanvaarden wegens status {acc2.Accountstate}");
                DisplayHaltMessage();
                return false;
            }
            return true;
        }


        private void DisplayHaltMessage()
        {
            Console.WriteLine("Druk enter om terug te keren ...");
            Console.ReadKey();
        }

        private string jester = @"
______________________     Q
|                    |  ___|\_.-,
|                    S\ Q~\___ \|
|   NICE             |(   )o 5) Q
|                    |\\  \_ ()
|   TRY !               | \'. _'/'.
|                   .-. '-(  x< \
|       ,o         /\, '.  )  /'\\
|______ \'.__.----/ .'\  '.-'/   \\
     snd '---'q__/.'__ ;    /     \\_
              '---'     '--'         ";
    }
}