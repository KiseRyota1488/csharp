using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using RacingStaff;

namespace RacePeleton
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Race race = new Race();

            await race.GettingDrivers();
        }
    }
}