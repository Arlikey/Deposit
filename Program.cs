namespace Deposit
{
    /*internal class Program
{
   static void Main(string[] args)
   {
       Credit credit = new Credit() {
           FullName = "John Smith",
           Amount = 25_000,
           DepositTerm = 24,
           Rate = 10,
           DepositDate = new DateOnly(2024, 2, 28)
       };

       Console.WriteLine(credit.Info());
       Console.WriteLine(credit.CloseDeposit(24));
   }

   public class Deposit
   {
       public virtual string Id { get; set; } = Guid.NewGuid().ToString();
       public virtual string FullName { get; set; }
       protected decimal amount;
       public virtual decimal Amount
       {
           get => amount;
           set => amount = value > 10_000 && value < 200_000 ? value : throw new Exception("Not valid amount!");
       }

       protected int depositTerm;
       public virtual int DepositTerm
       {
           get => depositTerm;
           set => depositTerm = value > 3 && value < 36 ? value : throw new Exception("Not valid deposit term!");
       }

       public virtual decimal Rate { get; set; }
       public virtual DateOnly DepositDate { get; set; }

       public virtual string Info()
       {
           return $"""
                   Id - {Id}
                   Full Name - {FullName}
                   Amount - {amount} $
                   Deposit Term - {depositTerm} m.
                   Rate - {Rate}%
                   Deposit Date - {DepositDate}
                   """;
       }

       public virtual decimal CloseDeposit(int passedMonth)
       {
           return amount * (1 * Rate / 100) * passedMonth / 12;
       }
   }

   public class Credit : Deposit
   {
       public override decimal Amount
       {
           get => amount;
           set => amount = value > 5000 && value < 500_000 ? value : throw new Exception("Not valid amount!");
       }

       public override int DepositTerm
       { 
           get => depositTerm;
           set => depositTerm = value > 1 && value < 60 ? value : throw new Exception("Not valid credit term!"); 
       }

       public override string Info()
       {
           return $"""
                   Id - {Id}
                   Full Name - {FullName}
                   Amount - {amount} $
                   Credit Term - {depositTerm} m.
                   Rate - {Rate}%
                   Credit Date - {DepositDate}
                   """; ;
       }
   }
}*/

    /*public class AdditionalTask1
    {
        static void Main()
        {
            Time time = new Time(0, 12, 45);
            Console.WriteLine(time.ToString());

            Time secondTime = time.Prev();
            Console.WriteLine(secondTime.ToString());
        }

        public class Time
        {
            public int Hours { get; private set; }
            public int Minutes { get; private set; }
            public int Seconds { get; private set; }

            public Time(int hours, int minutes, int seconds)
            {
                if ((hours < 0 || hours > 23) || (minutes < 0 || minutes > 59) || (seconds < 0 || seconds > 59)) { 
                    throw new Exception("Not valid time settings!");
                }
                Hours = hours;
                Minutes = minutes;
                Seconds = seconds;
            }

            public Time Next()
            {
                if (Hours == 23) { 
                    return new Time(0, Minutes, Seconds);
                }
                return new Time(Hours+1, Minutes, Seconds);
            }

            public Time Prev()
            {
                if (Hours == 0)
                {
                    return new Time(23, Minutes, Seconds);
                }
                return new Time(Hours - 1, Minutes, Seconds);
            }
            public Time Clone() => new Time(Hours, Minutes, Seconds);
            public override string ToString()
            {
                return $"{Hours:D2}:{Minutes:D2}:{Seconds:D2}";
            }
        }
    }*/

    /*public class AdditionalTask6
    {
        static void Main()
        {
            Notepad notepad = new Notepad("Notepad++", true, 1);
            Console.WriteLine(notepad.Info());

            Console.WriteLine("\n\n\n\n");

            Note note = new Note("Notepad", false, 2, "Hello World!");
            Console.WriteLine(note.Info());

        }

        public class Notepad
        {
            public Notepad(string name, bool license, int serialNumber)
            {
                Name = name;
                License = license;
                if (license == true) LicenceExpire = DateTime.Now.AddYears(1);
                SerialNumber = serialNumber;
            }

            public string Name { get; protected set; }
            public bool License { get; protected set; }

            public DateTime LicenceExpire { get; protected set; }
            public int SerialNumber { get; protected set; }

            public virtual string Info()
            {
                return $"""
                        Имя - {Name}
                        Лицензия: {(License == true ? $"активна\nДата истечения лицензии: {LicenceExpire}" : "не активна")}
                        Серийный номер - {SerialNumber}
                        """;
            }
        }

        public class Note : Notepad
        {
            public string Id { get; private set; } = Guid.NewGuid().ToString();
            private string description;
            public string Description 
            {
                get => description;
                set => description = value.Length > 10 ? value : throw new Exception("Not valid length!"); 
            }
            public DateTime CreateDate { get; set; } = DateTime.Now;
            public Note(string name, bool license, int serialNumber, string description) : base(name, license, serialNumber)
            {
                Description = description;
            }

            public override string Info()
            {
                return $"""
                        ID - {Id}
                        Дата создания заметки - {CreateDate}
                        Описание - {description}
                        """;
            }
        }
    }*/

}
