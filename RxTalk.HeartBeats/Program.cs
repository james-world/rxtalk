namespace RxTalk.HeartBeats
{
    using System;

    static class Program
    {
        static void Main()
        {
            var monitor = new ConnectionMonitor(TimeSpan.FromSeconds(5));

            monitor.Disconnections().Subscribe(
                clientId => Console.WriteLine("Client {0} disconnected.", clientId));

            string input = null;

            while (input != "q")
            {
                input = Console.ReadLine();
                int clientId;
                if (int.TryParse(input, out clientId))
                {
                    monitor.Pulse(clientId);
                }
            }
        }
    }
}
