namespace RxTalk.HeartBeats
{
    using System;
    using Microsoft.Reactive.Testing;
    using NUnit.Framework;

    public class ConnectionMonitorTests : ReactiveTest
    {
        [Test]
        public void MonitorReportsDisconnectionsCorrectly()
        {
            var scheduler = new TestScheduler();
            var clientPulses = scheduler.CreateColdObservable(
                OnNext(100, 1),
                OnNext(200, 2),
                OnNext(300, 1));

            var monitor = new ConnectionMonitor(TimeSpan.FromTicks(500), scheduler);

            clientPulses.Subscribe(x => monitor.Pulse(x));

            var results = scheduler.CreateObserver<int>();

            monitor.Disconnections().Subscribe(results);

            // scheduler.Start();

            results.Messages.AssertEqual(
                OnNext(700, 2),
                OnNext(800, 1));
        }
    }
}