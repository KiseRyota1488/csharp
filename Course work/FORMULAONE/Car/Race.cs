using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RacingStaff
{
    public class Race
    {
        Bolide[] cars = new Bolide[2] { new Bolide(44,"Lewis", "Hamilton", 360, 310), new Bolide(77, "Valtteri", "Bottas", 355, 290) };

        Track track = new Track();

        void OneMove()
        {

        }

        public async Task GettingDrivers()
        {
            using (FileStream fs = new FileStream(@"..\..\..\..\drivers.json", FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync<Bolide[]>(fs, cars);
                Console.WriteLine("Data has been saved to file");
            }
        }

    }
}
