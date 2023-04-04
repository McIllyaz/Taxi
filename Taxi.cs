using System;
namespace Pengenalanclass
{
	public class Taxi
	{
		public string Name { get; set; }
		public bool Duty { get; set; }
		public int Passanger { get; set; }

		public void Detail()
		{
            Console.WriteLine("Driver name \t\t: {0}", Name);
            Console.WriteLine("On duty\t\t\t: {0}", Duty);
            Console.WriteLine("Number of passanger\t: {0}", Passanger);
        }

		public void Pickup()
		{
            Console.WriteLine("{0} sedang menjemput penumpang.\n", Name);
        }

		public void Dropoff()
		{
            Console.WriteLine("{0} selesai mengantar penumpang.\n", Name);
        }

		public void Checker()
		{
            if (Duty == true)
            {
                Pickup();
            }
            else if (Duty == false)
            {
                Dropoff();
            }
            else
            {
                Console.WriteLine("Driver {0} sedang offline.\n", Name);
            }
        }
        

	}
}

