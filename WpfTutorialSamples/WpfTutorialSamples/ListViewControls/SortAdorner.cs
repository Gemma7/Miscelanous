using System.ComponentModel;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

namespace WpfTutorialSamples.ListViewControls
{
    public class SortAdorner : Adorner
    {
        private static Geometry ascGeometry = Geometry.Parse("M 0 4 L 3.5 0 L 7 4 Z");
        private static Geometry descGeometry = Geometry.Parse("M 0 0 L 3.5 4 L 7 0 Z");

        public ListSortDirection Direction { get; private set;  }

        public SortAdorner(UIElement adornedElement, ListSortDirection direction) : base(adornedElement)
        {
            Direction = direction;
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);

            if (AdornedElement.RenderSize.Width < 20)
                return;

            TranslateTransform transform = new TranslateTransform
            {
                X = AdornedElement.RenderSize.Width - 15,
                Y = (AdornedElement.RenderSize.Height - 5) / 2
            };

            drawingContext.PushTransform(transform);

            Geometry geometry = ascGeometry;

            if (Direction == ListSortDirection.Descending)
                geometry = descGeometry;

            drawingContext.DrawGeometry(Brushes.Black, null, geometry);

            drawingContext.Pop();
        }
    }
}