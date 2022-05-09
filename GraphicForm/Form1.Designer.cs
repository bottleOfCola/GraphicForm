namespace GraphicForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.go = new System.Windows.Forms.Button();
            this.graphica = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.a1 = new System.Windows.Forms.ToolStripMenuItem();
            this.a2 = new System.Windows.Forms.ToolStripMenuItem();
            this.a3 = new System.Windows.Forms.ToolStripMenuItem();
            this.a4 = new System.Windows.Forms.ToolStripMenuItem();
            this.a5 = new System.Windows.Forms.ToolStripMenuItem();
            this.a6 = new System.Windows.Forms.ToolStripMenuItem();
            this.a7 = new System.Windows.Forms.ToolStripMenuItem();
            this.a8 = new System.Windows.Forms.ToolStripMenuItem();
            this.a = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.na = new System.Windows.Forms.TextBox();
            this.nb = new System.Windows.Forms.TextBox();
            this.nc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.graphica)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // go
            // 
            this.go.Location = new System.Drawing.Point(129, 9);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(400, 23);
            this.go.TabIndex = 1;
            this.go.Text = "Нарисовать";
            this.go.UseVisualStyleBackColor = true;
            // 
            // graphica
            // 
            this.graphica.Location = new System.Drawing.Point(12, 38);
            this.graphica.Name = "graphica";
            this.graphica.Size = new System.Drawing.Size(900, 900);
            this.graphica.TabIndex = 2;
            this.graphica.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(9, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(117, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.a1,
            this.a2,
            this.a3,
            this.a4,
            this.a5,
            this.a6,
            this.a7,
            this.a8});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(109, 20);
            this.toolStripMenuItem1.Text = "Выбрать график";
            // 
            // a1
            // 
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(273, 22);
            this.a1.Text = "y=x*a+b";
            // 
            // a2
            // 
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(273, 22);
            this.a2.Text = "y = a*sin(x*b)+c";
            // 
            // a3
            // 
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(273, 22);
            this.a3.Text = "y = a*cos(x*b+c)";
            // 
            // a4
            // 
            this.a4.Name = "a4";
            this.a4.Size = new System.Drawing.Size(273, 22);
            this.a4.Text = "y = a*tg(x*b)+c";
            // 
            // a5
            // 
            this.a5.Name = "a5";
            this.a5.Size = new System.Drawing.Size(273, 22);
            this.a5.Text = "y = a*ctg(x*b+c)";
            // 
            // a6
            // 
            this.a6.Name = "a6";
            this.a6.Size = new System.Drawing.Size(273, 22);
            this.a6.Text = "y = b*x^2";
            // 
            // a7
            // 
            this.a7.Name = "a7";
            this.a7.Size = new System.Drawing.Size(273, 22);
            this.a7.Text = "y = a^(x+b)";
            // 
            // a8
            // 
            this.a8.Name = "a8";
            this.a8.Size = new System.Drawing.Size(273, 22);
            this.a8.Text = "y = ((sin(x)+a*x)/((x-x^0.5)+1))^(b/x)";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(532, 14);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(29, 15);
            this.a.TabIndex = 7;
            this.a.Text = "A = ";
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(606, 14);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(25, 15);
            this.b.TabIndex = 8;
            this.b.Text = "B =";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(687, 13);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(26, 15);
            this.c.TabIndex = 9;
            this.c.Text = "C =";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // na
            // 
            this.na.Location = new System.Drawing.Point(556, 11);
            this.na.Name = "na";
            this.na.Size = new System.Drawing.Size(44, 23);
            this.na.TabIndex = 10;
            // 
            // nb
            // 
            this.nb.Location = new System.Drawing.Point(637, 10);
            this.nb.Name = "nb";
            this.nb.Size = new System.Drawing.Size(44, 23);
            this.nb.TabIndex = 11;
            // 
            // nc
            // 
            this.nc.Location = new System.Drawing.Point(719, 11);
            this.nc.Name = "nc";
            this.nc.Size = new System.Drawing.Size(44, 23);
            this.nc.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(920, 961);
            this.Controls.Add(this.nc);
            this.Controls.Add(this.nb);
            this.Controls.Add(this.na);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.graphica);
            this.Controls.Add(this.go);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(936, 1000);
            this.MinimumSize = new System.Drawing.Size(936, 982);
            this.Name = "Form1";
            this.Text = "Графики!";
            ((System.ComponentModel.ISupportInitialize)(this.graphica)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button go;
        private PictureBox graphica;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem a1;
        private ToolStripMenuItem a2;
        private ToolStripMenuItem a3;
        private ToolStripMenuItem a4;
        private ToolStripMenuItem a5;
        private ToolStripMenuItem a6;
        private ToolStripMenuItem a7;
        private ToolStripMenuItem a8;
        private Label a;
        private Label b;
        private Label c;
        private FileSystemWatcher fileSystemWatcher1;
        private TextBox nc;
        private TextBox nb;
        private TextBox na;
    }
}