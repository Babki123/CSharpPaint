namespace MatchingSymbol
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
            colorDialog1 = new ColorDialog();
            panel1 = new Panel();
            panel2 = new Panel();
            button2 = new Button();
            BrushSizeDisplay = new TextBox();
            DrawSizeUp = new Button();
            PaintCross = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button7 = new Button();
            button8 = new Button();
            cyan = new Button();
            darkblue = new Button();
            darkred = new Button();
            green = new Button();
            black = new Button();
            red = new Button();
            white = new Button();
            DrawingArea = new PictureBox();
            colorDialog2 = new ColorDialog();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DrawingArea).BeginInit();
            SuspendLayout();
            // 
            // colorDialog1
            // 
            colorDialog1.Color = Color.IndianRed;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(PaintCross);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(button11);
            panel1.Controls.Add(button12);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(cyan);
            panel1.Controls.Add(darkblue);
            panel1.Controls.Add(darkred);
            panel1.Controls.Add(green);
            panel1.Controls.Add(black);
            panel1.Controls.Add(red);
            panel1.Controls.Add(white);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 361);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 89);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(BrushSizeDisplay);
            panel2.Controls.Add(DrawSizeUp);
            panel2.Location = new Point(350, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(67, 49);
            panel2.TabIndex = 14;
            // 
            // button2
            // 
            button2.Location = new Point(3, 26);
            button2.Name = "button2";
            button2.Size = new Size(18, 14);
            button2.TabIndex = 1;
            button2.Text = "↓";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // BrushSizeDisplay
            // 
            BrushSizeDisplay.AllowDrop = true;
            BrushSizeDisplay.Font = new Font("Segoe UI", 20F);
            BrushSizeDisplay.Location = new Point(27, 3);
            BrushSizeDisplay.Name = "BrushSizeDisplay";
            BrushSizeDisplay.Size = new Size(37, 43);
            BrushSizeDisplay.TabIndex = 2;
            BrushSizeDisplay.Text = "1";
            BrushSizeDisplay.TextAlign = HorizontalAlignment.Center;
            // 
            // DrawSizeUp
            // 
            DrawSizeUp.Location = new Point(3, 3);
            DrawSizeUp.Name = "DrawSizeUp";
            DrawSizeUp.Size = new Size(18, 17);
            DrawSizeUp.TabIndex = 0;
            DrawSizeUp.Text = "↑";
            DrawSizeUp.UseVisualStyleBackColor = true;
            DrawSizeUp.Click += DrawSizeUp_Click;
            // 
            // PaintCross
            // 
            PaintCross.Location = new Point(250, 50);
            PaintCross.Name = "PaintCross";
            PaintCross.Size = new Size(75, 23);
            PaintCross.TabIndex = 13;
            PaintCross.Text = "PaintCross";
            PaintCross.UseVisualStyleBackColor = true;
            PaintCross.Click += OnClickCross;
            // 
            // button10
            // 
            button10.BackColor = Color.White;
            button10.Location = new Point(91, 29);
            button10.Name = "button10";
            button10.Size = new Size(24, 23);
            button10.TabIndex = 12;
            button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.BackColor = Color.White;
            button11.Location = new Point(63, 61);
            button11.Name = "button11";
            button11.Size = new Size(24, 23);
            button11.TabIndex = 11;
            button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            button12.BackColor = Color.White;
            button12.Location = new Point(91, 61);
            button12.Name = "button12";
            button12.Size = new Size(24, 23);
            button12.TabIndex = 10;
            button12.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.Location = new Point(91, 0);
            button7.Name = "button7";
            button7.Size = new Size(24, 23);
            button7.TabIndex = 9;
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.Location = new Point(33, 61);
            button8.Name = "button8";
            button8.Size = new Size(24, 23);
            button8.TabIndex = 8;
            button8.UseVisualStyleBackColor = false;
            // 
            // cyan
            // 
            cyan.BackColor = Color.Cyan;
            cyan.Location = new Point(3, 61);
            cyan.Name = "cyan";
            cyan.Size = new Size(24, 23);
            cyan.TabIndex = 7;
            cyan.UseVisualStyleBackColor = false;
            // 
            // darkblue
            // 
            darkblue.BackColor = Color.FromArgb(0, 0, 64);
            darkblue.Location = new Point(61, 32);
            darkblue.Name = "darkblue";
            darkblue.Size = new Size(24, 23);
            darkblue.TabIndex = 6;
            darkblue.UseVisualStyleBackColor = false;
            darkblue.Click += SetBrushColor;
            // 
            // darkred
            // 
            darkred.BackColor = Color.FromArgb(192, 0, 0);
            darkred.Location = new Point(33, 32);
            darkred.Name = "darkred";
            darkred.Size = new Size(24, 23);
            darkred.TabIndex = 5;
            darkred.UseVisualStyleBackColor = false;
            // 
            // green
            // 
            green.BackColor = Color.FromArgb(0, 192, 0);
            green.Location = new Point(3, 32);
            green.Name = "green";
            green.Size = new Size(24, 23);
            green.TabIndex = 4;
            green.UseVisualStyleBackColor = false;
            green.Click += SetBrushColor;
            // 
            // black
            // 
            black.BackColor = Color.Black;
            black.Location = new Point(61, 3);
            black.Name = "black";
            black.Size = new Size(24, 23);
            black.TabIndex = 3;
            black.UseVisualStyleBackColor = false;
            // 
            // red
            // 
            red.BackColor = Color.Red;
            red.Location = new Point(33, 3);
            red.Name = "red";
            red.Size = new Size(24, 23);
            red.TabIndex = 2;
            red.UseVisualStyleBackColor = false;
            // 
            // white
            // 
            white.BackColor = Color.White;
            white.Location = new Point(3, 3);
            white.Name = "white";
            white.Size = new Size(24, 23);
            white.TabIndex = 1;
            white.UseVisualStyleBackColor = false;
            // 
            // DrawingArea
            // 
            DrawingArea.BackColor = Color.White;
            DrawingArea.Location = new Point(12, 12);
            DrawingArea.Name = "DrawingArea";
            DrawingArea.Size = new Size(776, 343);
            DrawingArea.TabIndex = 0;
            DrawingArea.TabStop = false;
            DrawingArea.MouseDown += OnClickColor;
            DrawingArea.MouseMove += OnMouseMove;
            DrawingArea.MouseUp += OnMouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(DrawingArea);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DrawingArea).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ColorDialog colorDialog1;
        private Panel panel1;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button7;
        private Button button8;
        private Button cyan;
        private Button darkblue;
        private Button darkred;
        private Button green;
        private Button black;
        private Button red;
        private Button white;
        private Button PaintCross;
        internal PictureBox DrawingArea;
        private Panel panel2;
        private TextBox BrushSizeDisplay;
        private Button button2;
        private Button DrawSizeUp;
        private ColorDialog colorDialog2;
    }
}
