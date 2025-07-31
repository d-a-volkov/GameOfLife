
namespace GameOfLife
{
    public partial class FormMain : Form
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
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            lblDensity = new Label();
            numericUpDownDensity = new NumericUpDown();
            lblResolution = new Label();
            numericUpDownResolution = new NumericUpDown();
            btnStop = new Button();
            btnStart = new Button();
            pictureBoxFields = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDensity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownResolution).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFields).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lblDensity);
            splitContainer1.Panel1.Controls.Add(numericUpDownDensity);
            splitContainer1.Panel1.Controls.Add(lblResolution);
            splitContainer1.Panel1.Controls.Add(numericUpDownResolution);
            splitContainer1.Panel1.Controls.Add(btnStop);
            splitContainer1.Panel1.Controls.Add(btnStart);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pictureBoxFields);
            splitContainer1.Size = new Size(1302, 556);
            splitContainer1.SplitterDistance = 175;
            splitContainer1.TabIndex = 0;
            // 
            // lblDensity
            // 
            lblDensity.AutoSize = true;
            lblDensity.Location = new Point(10, 51);
            lblDensity.Name = "lblDensity";
            lblDensity.Size = new Size(66, 15);
            lblDensity.TabIndex = 4;
            lblDensity.Text = "Плотность";
            // 
            // numericUpDownDensity
            // 
            numericUpDownDensity.Location = new Point(10, 69);
            numericUpDownDensity.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            numericUpDownDensity.Name = "numericUpDownDensity";
            numericUpDownDensity.Size = new Size(146, 23);
            numericUpDownDensity.TabIndex = 5;
            numericUpDownDensity.TextAlign = HorizontalAlignment.Right;
            numericUpDownDensity.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // lblResolution
            // 
            lblResolution.AutoSize = true;
            lblResolution.Location = new Point(10, 7);
            lblResolution.Name = "lblResolution";
            lblResolution.Size = new Size(75, 15);
            lblResolution.TabIndex = 1;
            lblResolution.Text = "Разрешение";
            // 
            // numericUpDownResolution
            // 
            numericUpDownResolution.Location = new Point(10, 25);
            numericUpDownResolution.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDownResolution.Name = "numericUpDownResolution";
            numericUpDownResolution.Size = new Size(146, 23);
            numericUpDownResolution.TabIndex = 3;
            numericUpDownResolution.TextAlign = HorizontalAlignment.Right;
            numericUpDownResolution.Value = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDownResolution.ValueChanged += numericUpDownResolution_ValueChanged;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(36, 152);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(90, 28);
            btnStop.TabIndex = 2;
            btnStop.Text = "Стоп";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(36, 118);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(90, 28);
            btnStart.TabIndex = 1;
            btnStart.Text = "Старт";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // pictureBoxFields
            // 
            pictureBoxFields.Dock = DockStyle.Fill;
            pictureBoxFields.Location = new Point(0, 0);
            pictureBoxFields.Name = "pictureBoxFields";
            pictureBoxFields.Size = new Size(1119, 552);
            pictureBoxFields.TabIndex = 0;
            pictureBoxFields.TabStop = false;
            pictureBoxFields.MouseMove += pictureBoxFields_MouseMove;
            // 
            // timer1
            // 
            timer1.Interval = 40;
            timer1.Tick += timer1_Tick;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1302, 556);
            Controls.Add(splitContainer1);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Игра \"Жизнь\"";
            WindowState = FormWindowState.Maximized;
            Shown += FormMain_Shown;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownDensity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownResolution).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFields).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnStop;
        private Button btnStart;
        private NumericUpDown numericUpDownResolution;
        private Label lblResolution;
        private Label lblDensity;
        private NumericUpDown numericUpDownDensity;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBoxFields;
    }
}
