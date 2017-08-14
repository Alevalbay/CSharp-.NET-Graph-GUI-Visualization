namespace Graph_Implementation {
    partial class mainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            Graph_Implementation.Graph graph1 = new Graph_Implementation.Graph();
            this.label1 = new System.Windows.Forms.Label();
            this.tbInitial = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.rbDijkstra = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rbFloyd = new System.Windows.Forms.RadioButton();
            this.rbDFS = new System.Windows.Forms.RadioButton();
            this.rbBFS = new System.Windows.Forms.RadioButton();
            this.btnCloseTab = new Graph_Implementation.CButton();
            this.btnAddTab = new Graph_Implementation.CButton();
            this.btnRun = new Graph_Implementation.CButton();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Initial Vertex Id:";
            // 
            // tbInitial
            // 
            this.tbInitial.Location = new System.Drawing.Point(97, 12);
            this.tbInitial.Name = "tbInitial";
            this.tbInitial.Size = new System.Drawing.Size(90, 20);
            this.tbInitial.TabIndex = 1;
            this.tbInitial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(new GPage(new Graph(), "New Tab"));
            this.tabControl.Location = new System.Drawing.Point(12, 67);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1066, 578);
            this.tabControl.TabIndex = 3;
            // 
            // rbDijkstra
            // 
            this.rbDijkstra.AutoSize = true;
            this.rbDijkstra.Checked = true;
            this.rbDijkstra.Location = new System.Drawing.Point(97, 38);
            this.rbDijkstra.Name = "rbDijkstra";
            this.rbDijkstra.Size = new System.Drawing.Size(67, 17);
            this.rbDijkstra.TabIndex = 4;
            this.rbDijkstra.TabStop = true;
            this.rbDijkstra.Text = "Dijkstra\'s";
            this.rbDijkstra.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Algorithm:";
            // 
            // rbFloyd
            // 
            this.rbFloyd.AutoSize = true;
            this.rbFloyd.Location = new System.Drawing.Point(170, 38);
            this.rbFloyd.Name = "rbFloyd";
            this.rbFloyd.Size = new System.Drawing.Size(94, 17);
            this.rbFloyd.TabIndex = 4;
            this.rbFloyd.Text = "Floyd-Warshall";
            this.rbFloyd.UseVisualStyleBackColor = true;
            // 
            // rbDFS
            // 
            this.rbDFS.AutoSize = true;
            this.rbDFS.Location = new System.Drawing.Point(270, 39);
            this.rbDFS.Name = "rbDFS";
            this.rbDFS.Size = new System.Drawing.Size(46, 17);
            this.rbDFS.TabIndex = 4;
            this.rbDFS.Text = "DFS";
            this.rbDFS.UseVisualStyleBackColor = true;
            // 
            // rbBFS
            // 
            this.rbBFS.AutoSize = true;
            this.rbBFS.Location = new System.Drawing.Point(322, 38);
            this.rbBFS.Name = "rbBFS";
            this.rbBFS.Size = new System.Drawing.Size(45, 17);
            this.rbBFS.TabIndex = 4;
            this.rbBFS.Text = "BFS";
            this.rbBFS.UseVisualStyleBackColor = true;
            // 
            // btnCloseTab
            // 
            this.btnCloseTab.Location = new System.Drawing.Point(958, 15);
            this.btnCloseTab.Name = "btnCloseTab";
            this.btnCloseTab.Size = new System.Drawing.Size(120, 23);
            this.btnCloseTab.TabIndex = 2;
            this.btnCloseTab.Text = "Close Current Tab";
            this.btnCloseTab.UseVisualStyleBackColor = true;
            this.btnCloseTab.Click += new System.EventHandler(this.btnCloseTab_Click);
            // 
            // btnAddTab
            // 
            this.btnAddTab.Location = new System.Drawing.Point(958, 39);
            this.btnAddTab.Name = "btnAddTab";
            this.btnAddTab.Size = new System.Drawing.Size(120, 23);
            this.btnAddTab.TabIndex = 2;
            this.btnAddTab.Text = "Add Tab";
            this.btnAddTab.UseVisualStyleBackColor = true;
            this.btnAddTab.Click += new System.EventHandler(this.btnAddTab_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(193, 10);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(90, 23);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 648);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.rbBFS);
            this.Controls.Add(this.rbDFS);
            this.Controls.Add(this.rbFloyd);
            this.Controls.Add(this.rbDijkstra);
            this.Controls.Add(this.btnCloseTab);
            this.Controls.Add(this.btnAddTab);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.tbInitial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graph Implementation";
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInitial;
        private CButton btnRun;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.RadioButton rbDijkstra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbFloyd;
        private System.Windows.Forms.RadioButton rbDFS;
        private System.Windows.Forms.RadioButton rbBFS;
        private CButton btnAddTab;
        private CButton btnCloseTab;
    }
}

