﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLDesigner
{
    class RealizationArrows: Arrow
    {
        public RealizationArrows(Pen pen, Point start, Point finish) : base(pen, start, finish)
        {
            ArrowPen.CustomEndCap = new AdjustableArrowCap(10, 10);
        }

        public override void DrawArrow(Graphics graphics, Point start, Point finish)
        {
            FinishPoint = finish;
            ArrowPen.DashStyle = DashStyle.Dash;

            GraphicsPath hPath = new GraphicsPath();
            Point[] emptyTriangle = new Point[] { new Point(-6, 0),
                                                    new Point(6, 0),
                                                    new Point(0, 12),
                                                  };

            hPath.AddPolygon(emptyTriangle);
            ArrowPen.CustomEndCap = new CustomLineCap(null, hPath);

            graphics.DrawLine(ArrowPen, start, finish);
        }
    }
}
