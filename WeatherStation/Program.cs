using static AngelHornetLibrary.CLI.CliSystem;

namespace WeatherStation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // WARNING: FindFileInVisualStudio is only intended for use while debugging COMMAND LINE only apps inside the Visual Studio IDE.
            String? ghcndStationsFileName = FindFileInVisualStudio("ghcnd-stations.txt");
            Console.WriteLine("ghcnd-stations.txt: " + ghcndStationsFileName);

            String? ghcndStatesFileName = FindFileInVisualStudio("ghcnd-states.txt");
            Console.WriteLine("ghcnd-states.txt: " + ghcndStatesFileName);

            // add code here ... 
        }
    }
}
