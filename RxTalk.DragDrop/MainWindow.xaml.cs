namespace RxTalk.DragDrop
{
    using System;
    using System.Reactive.Linq;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using System.Windows.Media;

    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            var mouseMoves = Observable.FromEventPattern<MouseEventArgs>(Canvas, "MouseMove")
                .Select(x => x.EventArgs.GetPosition(Canvas));

            var mouseUps = Observable.FromEventPattern<MouseButtonEventArgs>(Canvas, "MouseLeftButtonUp");

            var mouseDowns = Observable.FromEventPattern<MouseButtonEventArgs>(Rectangle, "MouseLeftButtonDown")
                .Select(x => x.EventArgs.GetPosition(Canvas));

            var drag =
                from mouseDown in mouseDowns
                from delta in Deltas(mouseDown, mouseMoves).TakeUntil(mouseUps)
                select delta;

            drag.Subscribe(OnDrag);
        }

        private void OnDrag(TranslateTransform e)
        {
            Canvas.SetLeft(Rectangle, Canvas.GetLeft(Rectangle) + e.X);
            Canvas.SetTop(Rectangle, Canvas.GetTop(Rectangle) + e.Y);
        }

        private IObservable<TranslateTransform> Deltas(Point start, IObservable<Point> moves)
        {
            // moves.StartWith(start)
            // S------1-------2-------3-------4

            // moves
            // -------1-------2-------3-------4

            // Zip
            // -----(S,1)---(1,2)---(2,3)---(3,4)

            return moves.StartWith(start)
                        .Zip(moves, (original, next) =>
                            new TranslateTransform(next.X - original.X, next.Y - original.Y));
        }
    }
}
