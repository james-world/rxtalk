namespace RxTalk.HeartBeats
{
    using System;
    using System.Reactive.Concurrency;
    using System.Reactive.Linq;
    using System.Reactive.Subjects;

    public class ConnectionMonitor
    {
        private readonly Subject<int> _clientHeartbeats = new Subject<int>();
        private readonly TimeSpan _minimumInternval;
        private readonly IScheduler _scheduler;

        public ConnectionMonitor(
            TimeSpan minimumInternval,
            IScheduler scheduler = null)
        {
            _scheduler = scheduler ?? Scheduler.Default;
            _minimumInternval = minimumInternval;
        }

        public IObservable<int> Disconnections()
        {
            return _clientHeartbeats
                .Synchronize()
                .GroupBy(key => key)
                .SelectMany(grp => grp.Throttle(_minimumInternval, _scheduler));
        }

        public void Pulse(int clientId)
        {
            _clientHeartbeats.OnNext(clientId);
        }
    }
}