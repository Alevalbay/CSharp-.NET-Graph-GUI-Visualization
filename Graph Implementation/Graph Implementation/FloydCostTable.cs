using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Graph_Implementation {

    public partial class FloydCostTable : Form {

        public FloydCostTable(Graph _Graph, int[,] Costs) {

            InitializeComponent();

            this.pbTable.Paint += (object sender, PaintEventArgs e) => {

                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // Horizonal Label Reconstruction
                int x = mainForm.MATRIX_GRID_W, y = 0;
                for (int i = 0; i < _Graph.V; i++) {

                    e.Graphics.DrawString(string.Format("{0,2}", i + 1), new Font("Roboto Condensed", 9, FontStyle.Italic), new SolidBrush(Color.Black), x + 7, y);
                    x += mainForm.MATRIX_GRID_W;
                }

                // Vertical Label Reconstruction
                x = 0; y = mainForm.MATRIX_GRID_H;
                for (int i = 0; i < _Graph.V; i++) {

                    e.Graphics.DrawString(string.Format("{0,2}", i + 1), new Font("Roboto Condensed", 9, FontStyle.Italic), new SolidBrush(Color.Black), x, y + 7);
                    y += mainForm.MATRIX_GRID_H;
                }

                // ------------ ADJACENCY MATRIX RECONSTRUCTION ------------ //

                x = mainForm.MATRIX_GRID_W; y = mainForm.MATRIX_GRID_H;
                for (int i = 0; i < _Graph.V; i++) {

                    for (int j = 0; j < _Graph.V; j++) {

                        e.Graphics.DrawRectangle(new Pen(SystemColors.ActiveBorder, 1), x, y, mainForm.MATRIX_GRID_W, mainForm.MATRIX_GRID_H);

                        if (i == j)
                            e.Graphics.DrawString(string.Format("{0,2}", "-"), new Font("Consolas", 10, FontStyle.Regular), new SolidBrush(Color.Black), x + 2, y + 7);

                        else if (Costs[i, j] == 999)
                            e.Graphics.DrawString(string.Format("{0,2}", "∞"), new Font("Consolas", 10, FontStyle.Regular), new SolidBrush(Color.Black), x + 2, y + 7);

                        else
                            e.Graphics.DrawString(string.Format("{0,2}", Costs[i, j]), new Font("Consolas", 10, FontStyle.Regular), new SolidBrush(Color.Black), x + 2, y + 7);

                        x += mainForm.MATRIX_GRID_W;
                    }

                    x = mainForm.MATRIX_GRID_W;
                    y += mainForm.MATRIX_GRID_H;
                }
            };
        }
    }
}
