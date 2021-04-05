﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLDesigner
{
    class AssociationArrows: Arrow
    {
        public AssociationArrows(Pen pen, Point start, Point finish) : base(pen, start, finish)
        {
            Pen.CustomEndCap = new AdjustableArrowCap(10, 10, false);
        }

        public override void DrawArrow(Graphics graphics, Point start, Point finish)
        {
            FinishPoint = finish;
            graphics.DrawLine(Pen, start, finish);
        }
    }
}
