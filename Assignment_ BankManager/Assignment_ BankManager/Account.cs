using Assignment__BankManager;

namespace Assignment_BankManager
{
    public class Account
    {
        public Account(string naam, long rekeningnummer, decimal bedrag, Accountstate accountstate)
        {
            if (string.IsNullOrEmpty(naam))
                throw new ArgumentNullException(nameof(naam));

            Naam = naam;
            Rekeningnummer = rekeningnummer;
            Bedrag = bedrag;
            Accountstate = accountstate;
        }

        private readonly Menu _menu;
        public Account(Menu menu)
        {
            _menu = menu;
        }

        private string _naam;
        private long _rekeningnummer;
        private decimal _bedrag;

        public string Naam 
        { 
            get
            {
                return _naam;
            }
            set
            {
                _naam = value;
            }
        }
        public decimal Bedrag
        {
            get
            {
                return _bedrag;
            }
            set
            {
                _bedrag = value;
            }
        }
        public long Rekeningnummer
        {
            get
            {
                return _rekeningnummer;
            }
            set
            {
                _rekeningnummer = value;
            }
        }

        public Accountstate Accountstate;
    }
}