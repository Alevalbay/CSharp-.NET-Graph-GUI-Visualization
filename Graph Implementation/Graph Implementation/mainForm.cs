using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Graph_Implementation {

    public partial class mainForm : Form {

        public const int VERTEX_LIMIT  = 14;
        public const int GRAPH_LIMIT   = 15;
        public const int INITIAL_COST  = 1;
        public const int MATRIX_GRID_W = 30;
        public const int MATRIX_GRID_H = 30;
        public const int CRADIUS       = 15;
        public const int CDIAMETER     = 30;

        public mainForm() {

            InitializeComponent();
        }

        private void btnAddTab_Click(object sender, EventArgs e) {

            this.AddTab();
        }

        private void btnCloseTab_Click(object sender, EventArgs e) {

            if (this.tabControl.TabCount != 1) {

                this.tabControl.TabPages.RemoveAt(this.tabControl.SelectedIndex);
                this.tabControl.SelectedIndex = this.tabControl.TabCount - 1;
            }

            else
                MessageBox.Show("Cannot close the last standing tab!", "Warning");
        }

        private void AddTab() {

            if (this.tabControl.TabCount < GRAPH_LIMIT) {

                this.tabControl.TabPages.Add(new GPage(new Graph(), "New Tab"));
                this.tabControl.SelectedIndex = this.tabControl.TabCount - 1;
            }

            else
                MessageBox.Show("Tab limit is set to " + GRAPH_LIMIT + "!", "Warning");
        }

        private void btnRun_Click(object sender, EventArgs e) {

            int value;

            Graph invokeGraph     = ((this.tabControl.TabPages[this.tabControl.SelectedIndex]) as GPage).invokeGraph;
            RichTextBox invokeRTB = ((this.tabControl.TabPages[this.tabControl.SelectedIndex]) as GPage).rtbLogs;

            if (int.TryParse(tbInitial.Text, out value)) {

                if (rbDijkstra.Checked) {

                    invokeRTB.Text = string.Empty;
                    Graph.Dijkstra(invokeGraph, value - 1);

                    foreach (Vertex v in invokeGraph) {

                        if (v.id != value - 1) {

                            if (v.min_cost == int.MaxValue || v.min_cost == int.MaxValue * -1)
                                invokeRTB.Text += "Shortest distance between vertices " + value + " and " + (v.id + 1) + " is INFINITY" + Environment.NewLine;
                            
                            else
                                invokeRTB.Text += "Shortest distance between vertices " + value + " and " + (v.id + 1) + " is " + v.min_cost + Environment.NewLine;
                        }
                            

                        v.min_cost  = int.MaxValue;
                        v.permanent = false;
                    }

                    ((this.tabControl.TabPages[this.tabControl.SelectedIndex]) as GPage).tabControl.SelectedIndex = 1;
                }

                else if (rbDFS.Checked) {

                    foreach (Vertex v in invokeGraph)
                        v.visited = false;

                    invokeRTB.Text = "Depth First Search:\n>" + Graph.DFS(invokeGraph, value - 1);
                    ((this.tabControl.TabPages[this.tabControl.SelectedIndex]) as GPage).tabControl.SelectedIndex = 1;
                }

                else if (rbBFS.Checked) {

                    foreach (Vertex v in invokeGraph)
                        v.visited = false;

                    invokeRTB.Text = "Breadth First Search:\n>" + Graph.BFS(invokeGraph, value - 1);
                    ((this.tabControl.TabPages[this.tabControl.SelectedIndex]) as GPage).tabControl.SelectedIndex = 1;
                }
            }

            if (rbFloyd.Checked) {

                Graph.Floyd_Warshall(invokeGraph);
            }
        }
    }
}
