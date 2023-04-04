using System;

namespace Pengenalanclass // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi satu = new Taxi();
            Taxi dua = new Taxi();

            satu.Name = "Angga";
            satu.Duty = true;
            satu.Passanger = 5;

            satu.Detail();
            satu.Checker();

            dua.Name = "Brilyan";
            dua.Duty = false;
            dua.Passanger = 2;

            dua.Detail();
            dua.Checker();
        }
    }
}