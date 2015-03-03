namespace RxTalk.Gui
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reactive.Concurrency;
    using System.Reactive.Linq;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Controls;
    using DictService;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var service = new DictServiceSoapClient("DictServiceSoap");

            var terms = Observable.FromEventPattern<object, TextChangedEventArgs>(Terms, "TextChanged")
                .Select(x => ((TextBox) x.Sender).Text)
                .Where(x => x.Length >= 3)
                .Throttle(TimeSpan.FromSeconds(0.5), DispatcherScheduler.Current)
                .DistinctUntilChanged();

            Func<string, Task<IEnumerable<string>>> lookup = async term =>
            {
                var dictionaryWords = await service.MatchAsync(term, "prefix");
                return dictionaryWords.Select(x => x.Word);
            };

            terms.Select(x => lookup(x))
                 .Switch()
                 .ObserveOnDispatcher()
                 .Subscribe(res => Results.ItemsSource = res);
        }
    }
}
