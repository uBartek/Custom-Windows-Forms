namespace GUI_Base
{
    partial class GUI
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelRightForResize = new System.Windows.Forms.Panel();
            this.panelRightTopCornerForResize2 = new System.Windows.Forms.Panel();
            this.panelRightBottomCornerForResize1 = new System.Windows.Forms.Panel();
            this.panelBottomForResize = new System.Windows.Forms.Panel();
            this.panelLeftBottomCornerForResize2 = new System.Windows.Forms.Panel();
            this.panelRightBottomCornerForResize2 = new System.Windows.Forms.Panel();
            this.panelLeftForResize = new System.Windows.Forms.Panel();
            this.panelLeftTopCornerForResize1 = new System.Windows.Forms.Panel();
            this.panelLeftBottomCornerForResize1 = new System.Windows.Forms.Panel();
            this.panelTopForResize = new System.Windows.Forms.Panel();
            this.panelLeftTopCornerForResize2 = new System.Windows.Forms.Panel();
            this.panelRightTopCornerForResize1 = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonResize = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRightForResize.SuspendLayout();
            this.panelBottomForResize.SuspendLayout();
            this.panelLeftForResize.SuspendLayout();
            this.panelTopForResize.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRightForResize
            // 
            this.panelRightForResize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(153)))), ((int)(((byte)(84)))));
            this.panelRightForResize.Controls.Add(this.panelRightTopCornerForResize2);
            this.panelRightForResize.Controls.Add(this.panelRightBottomCornerForResize1);
            this.panelRightForResize.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.panelRightForResize.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRightForResize.Location = new System.Drawing.Point(798, 0);
            this.panelRightForResize.Name = "panelRightForResize";
            this.panelRightForResize.Size = new System.Drawing.Size(2, 450);
            this.panelRightForResize.TabIndex = 0;
            this.panelRightForResize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.borders_MouseDown);
            this.panelRightForResize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.borders_MouseMove);
            this.panelRightForResize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.borders_MouseUp);
            // 
            // panelRightTopCornerForResize2
            // 
            this.panelRightTopCornerForResize2.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.panelRightTopCornerForResize2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRightTopCornerForResize2.Location = new System.Drawing.Point(0, 0);
            this.panelRightTopCornerForResize2.MinimumSize = new System.Drawing.Size(4, 8);
            this.panelRightTopCornerForResize2.Name = "panelRightTopCornerForResize2";
            this.panelRightTopCornerForResize2.Size = new System.Drawing.Size(4, 8);
            this.panelRightTopCornerForResize2.TabIndex = 1;
            this.panelRightTopCornerForResize2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.borders_MouseDown);
            this.panelRightTopCornerForResize2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.borders_MouseMove);
            this.panelRightTopCornerForResize2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.borders_MouseUp);
            // 
            // panelRightBottomCornerForResize1
            // 
            this.panelRightBottomCornerForResize1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(153)))), ((int)(((byte)(84)))));
            this.panelRightBottomCornerForResize1.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.panelRightBottomCornerForResize1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRightBottomCornerForResize1.Location = new System.Drawing.Point(0, 442);
            this.panelRightBottomCornerForResize1.MinimumSize = new System.Drawing.Size(4, 8);
            this.panelRightBottomCornerForResize1.Name = "panelRightBottomCornerForResize1";
            this.panelRightBottomCornerForResize1.Size = new System.Drawing.Size(4, 8);
            this.panelRightBottomCornerForResize1.TabIndex = 0;
            this.panelRightBottomCornerForResize1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.borders_MouseDown);
            this.panelRightBottomCornerForResize1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.borders_MouseMove);
            this.panelRightBottomCornerForResize1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.borders_MouseUp);
            // 
            // panelBottomForResize
            // 
            this.panelBottomForResize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(153)))), ((int)(((byte)(84)))));
            this.panelBottomForResize.Controls.Add(this.panelLeftBottomCornerForResize2);
            this.panelBottomForResize.Controls.Add(this.panelRightBottomCornerForResize2);
            this.panelBottomForResize.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.panelBottomForResize.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomForResize.Location = new System.Drawing.Point(0, 448);
            this.panelBottomForResize.Name = "panelBottomForResize";
            this.panelBottomForResize.Size = new System.Drawing.Size(798, 2);
            this.panelBottomForResize.TabIndex = 1;
            this.panelBottomForResize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.borders_MouseDown);
            this.panelBottomForResize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.borders_MouseMove);
            this.panelBottomForResize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.borders_MouseUp);
            // 
            // panelLeftBottomCornerForResize2
            // 
            this.panelLeftBottomCornerForResize2.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.panelLeftBottomCornerForResize2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftBottomCornerForResize2.Location = new System.Drawing.Point(0, 0);
            this.panelLeftBottomCornerForResize2.MinimumSize = new System.Drawing.Size(8, 4);
            this.panelLeftBottomCornerForResize2.Name = "panelLeftBottomCornerForResize2";
            this.panelLeftBottomCornerForResize2.Size = new System.Drawing.Size(8, 4);
            this.panelLeftBottomCornerForResize2.TabIndex = 1;
            this.panelLeftBottomCornerForResize2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.borders_MouseDown);
            this.panelLeftBottomCornerForResize2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.borders_MouseMove);
            this.panelLeftBottomCornerForResize2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.borders_MouseUp);
            // 
            // panelRightBottomCornerForResize2
            // 
            this.panelRightBottomCornerForResize2.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.panelRightBottomCornerForResize2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRightBottomCornerForResize2.Location = new System.Drawing.Point(790, 0);
            this.panelRightBottomCornerForResize2.MinimumSize = new System.Drawing.Size(8, 4);
            this.panelRightBottomCornerForResize2.Name = "panelRightBottomCornerForResize2";
            this.panelRightBottomCornerForResize2.Size = new System.Drawing.Size(8, 4);
            this.panelRightBottomCornerForResize2.TabIndex = 0;
            this.panelRightBottomCornerForResize2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.borders_MouseDown);
            this.panelRightBottomCornerForResize2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.borders_MouseMove);
            this.panelRightBottomCornerForResize2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.borders_MouseUp);
            // 
            // panelLeftForResize
            // 
            this.panelLeftForResize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(153)))), ((int)(((byte)(84)))));
            this.panelLeftForResize.Controls.Add(this.panelLeftTopCornerForResize1);
            this.panelLeftForResize.Controls.Add(this.panelLeftBottomCornerForResize1);
            this.panelLeftForResize.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.panelLeftForResize.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftForResize.Location = new System.Drawing.Point(0, 0);
            this.panelLeftForResize.Name = "panelLeftForResize";
            this.panelLeftForResize.Size = new System.Drawing.Size(2, 448);
            this.panelLeftForResize.TabIndex = 2;
            this.panelLeftForResize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.borders_MouseDown);
            this.panelLeftForResize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.borders_MouseMove);
            this.panelLeftForResize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.borders_MouseUp);
            // 
            // panelLeftTopCornerForResize1
            // 
            this.panelLeftTopCornerForResize1.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.panelLeftTopCornerForResize1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLeftTopCornerForResize1.Location = new System.Drawing.Point(0, 0);
            this.panelLeftTopCornerForResize1.MinimumSize = new System.Drawing.Size(4, 8);
            this.panelLeftTopCornerForResize1.Name = "panelLeftTopCornerForResize1";
            this.panelLeftTopCornerForResize1.Size = new System.Drawing.Size(4, 8);
            this.panelLeftTopCornerForResize1.TabIndex = 3;
            this.panelLeftTopCornerForResize1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.borders_MouseDown);
            this.panelLeftTopCornerForResize1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.borders_MouseMove);
            this.panelLeftTopCornerForResize1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.borders_MouseUp);
            // 
            // panelLeftBottomCornerForResize1
            // 
            this.panelLeftBottomCornerForResize1.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.panelLeftBottomCornerForResize1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLeftBottomCornerForResize1.Location = new System.Drawing.Point(0, 440);
            this.panelLeftBottomCornerForResize1.MinimumSize = new System.Drawing.Size(4, 8);
            this.panelLeftBottomCornerForResize1.Name = "panelLeftBottomCornerForResize1";
            this.panelLeftBottomCornerForResize1.Size = new System.Drawing.Size(4, 8);
            this.panelLeftBottomCornerForResize1.TabIndex = 2;
            this.panelLeftBottomCornerForResize1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.borders_MouseDown);
            this.panelLeftBottomCornerForResize1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.borders_MouseMove);
            this.panelLeftBottomCornerForResize1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.borders_MouseUp);
            // 
            // panelTopForResize
            // 
            this.panelTopForResize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(153)))), ((int)(((byte)(84)))));
            this.panelTopForResize.Controls.Add(this.panelLeftTopCornerForResize2);
            this.panelTopForResize.Controls.Add(this.panelRightTopCornerForResize1);
            this.panelTopForResize.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.panelTopForResize.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopForResize.Location = new System.Drawing.Point(2, 0);
            this.panelTopForResize.Name = "panelTopForResize";
            this.panelTopForResize.Size = new System.Drawing.Size(796, 2);
            this.panelTopForResize.TabIndex = 3;
            this.panelTopForResize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.borders_MouseDown);
            this.panelTopForResize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.borders_MouseMove);
            this.panelTopForResize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.borders_MouseUp);
            // 
            // panelLeftTopCornerForResize2
            // 
            this.panelLeftTopCornerForResize2.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.panelLeftTopCornerForResize2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftTopCornerForResize2.Location = new System.Drawing.Point(0, 0);
            this.panelLeftTopCornerForResize2.MinimumSize = new System.Drawing.Size(8, 4);
            this.panelLeftTopCornerForResize2.Name = "panelLeftTopCornerForResize2";
            this.panelLeftTopCornerForResize2.Size = new System.Drawing.Size(8, 4);
            this.panelLeftTopCornerForResize2.TabIndex = 2;
            this.panelLeftTopCornerForResize2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.borders_MouseDown);
            this.panelLeftTopCornerForResize2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.borders_MouseMove);
            this.panelLeftTopCornerForResize2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.borders_MouseUp);
            // 
            // panelRightTopCornerForResize1
            // 
            this.panelRightTopCornerForResize1.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.panelRightTopCornerForResize1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRightTopCornerForResize1.Location = new System.Drawing.Point(788, 0);
            this.panelRightTopCornerForResize1.MinimumSize = new System.Drawing.Size(8, 4);
            this.panelRightTopCornerForResize1.Name = "panelRightTopCornerForResize1";
            this.panelRightTopCornerForResize1.Size = new System.Drawing.Size(8, 4);
            this.panelRightTopCornerForResize1.TabIndex = 1;
            this.panelRightTopCornerForResize1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.borders_MouseDown);
            this.panelRightTopCornerForResize1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.borders_MouseMove);
            this.panelRightTopCornerForResize1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.borders_MouseUp);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panelTop.Controls.Add(this.buttonMinimize);
            this.panelTop.Controls.Add(this.buttonResize);
            this.panelTop.Controls.Add(this.buttonExit);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(2, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(796, 30);
            this.panelTop.TabIndex = 4;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseUp);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackgroundImage = global::GUI_Base.Properties.Resources.icons8_minimize_window_24;
            this.buttonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.buttonMinimize.Location = new System.Drawing.Point(706, 0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(30, 30);
            this.buttonMinimize.TabIndex = 2;
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonResize
            // 
            this.buttonResize.BackgroundImage = global::GUI_Base.Properties.Resources.icons8_maximize_button_24;
            this.buttonResize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonResize.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonResize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.buttonResize.Location = new System.Drawing.Point(736, 0);
            this.buttonResize.Name = "buttonResize";
            this.buttonResize.Size = new System.Drawing.Size(30, 30);
            this.buttonResize.TabIndex = 1;
            this.buttonResize.UseVisualStyleBackColor = true;
            this.buttonResize.Click += new System.EventHandler(this.buttonResize_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackgroundImage = global::GUI_Base.Properties.Resources.icons8_close_window_24__1_;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.buttonExit.Location = new System.Drawing.Point(766, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(30, 30);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            this.buttonExit.MouseEnter += new System.EventHandler(this.buttonExit_MouseEnter);
            this.buttonExit.MouseLeave += new System.EventHandler(this.buttonExit_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(637, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "https://icons8.com";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelTopForResize);
            this.Controls.Add(this.panelLeftForResize);
            this.Controls.Add(this.panelBottomForResize);
            this.Controls.Add(this.panelRightForResize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(400, 225);
            this.Name = "GUI";
            this.Text = "Form1";
            this.panelRightForResize.ResumeLayout(false);
            this.panelBottomForResize.ResumeLayout(false);
            this.panelLeftForResize.ResumeLayout(false);
            this.panelTopForResize.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelRightForResize;
        private System.Windows.Forms.Panel panelBottomForResize;
        private System.Windows.Forms.Panel panelLeftForResize;
        private System.Windows.Forms.Panel panelTopForResize;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonResize;
        private System.Windows.Forms.Panel panelRightBottomCornerForResize1;
        private System.Windows.Forms.Panel panelRightBottomCornerForResize2;
        private System.Windows.Forms.Panel panelLeftBottomCornerForResize2;
        private System.Windows.Forms.Panel panelLeftBottomCornerForResize1;
        private System.Windows.Forms.Panel panelRightTopCornerForResize2;
        private System.Windows.Forms.Panel panelLeftTopCornerForResize1;
        private System.Windows.Forms.Panel panelLeftTopCornerForResize2;
        private System.Windows.Forms.Panel panelRightTopCornerForResize1;
        private System.Windows.Forms.Label label1;
    }
}

