using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Graph_Implementation {

    class CPictureBox : PictureBox {

        protected override void OnPaint(PaintEventArgs e) {

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(217, 217, 217)), new
                Rectangle(0, 0, this.ClientSize.Width - 1, this.ClientSize.Height - 1));

            base.OnPaint(e);
        }
    }
}
