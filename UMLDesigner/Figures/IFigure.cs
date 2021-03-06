using System.Drawing;

namespace UMLDesigner.Figures
{
    public interface IFigure : IMovable
    {
        Point StartPoint { get; set; }
        Point FinishPoint { get; set; }
        Pen FigurePen { get; set; }

        void Draw();
    }
}
