namespace Dozer
{
    partial class FormCarConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxAssembly = new System.Windows.Forms.GroupBox();
            this.labelDozer = new System.Windows.Forms.Label();
            this.labelCar = new System.Windows.Forms.Label();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.checkBoxTruba = new System.Windows.Forms.CheckBox();
            this.checkBoxKovsh = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.pictureBoxDozer = new System.Windows.Forms.PictureBox();
            this.panelDozer = new System.Windows.Forms.Panel();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelPurple = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelAqua = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelPink = new System.Windows.Forms.Panel();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxAssembly.SuspendLayout();
            this.groupBoxOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDozer)).BeginInit();
            this.panelDozer.SuspendLayout();
            this.groupBoxColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAssembly
            // 
            this.groupBoxAssembly.Controls.Add(this.labelDozer);
            this.groupBoxAssembly.Controls.Add(this.labelCar);
            this.groupBoxAssembly.Location = new System.Drawing.Point(26, 20);
            this.groupBoxAssembly.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxAssembly.Name = "groupBoxAssembly";
            this.groupBoxAssembly.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxAssembly.Size = new System.Drawing.Size(148, 100);
            this.groupBoxAssembly.TabIndex = 0;
            this.groupBoxAssembly.TabStop = false;
            this.groupBoxAssembly.Text = "Тип сборки";
            // 
            // labelDozer
            // 
            this.labelDozer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDozer.Location = new System.Drawing.Point(12, 55);
            this.labelDozer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDozer.Name = "labelDozer";
            this.labelDozer.Size = new System.Drawing.Size(118, 26);
            this.labelDozer.TabIndex = 2;
            this.labelDozer.Text = "Бульдозер";
            this.labelDozer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelDozer_MouseDown);
            // 
            // labelCar
            // 
            this.labelCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCar.Location = new System.Drawing.Point(12, 15);
            this.labelCar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCar.Name = "labelCar";
            this.labelCar.Size = new System.Drawing.Size(118, 27);
            this.labelCar.TabIndex = 1;
            this.labelCar.Text = "Транспорт";
            this.labelCar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelCar_MouseDown);
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.checkBoxTruba);
            this.groupBoxOptions.Controls.Add(this.checkBoxKovsh);
            this.groupBoxOptions.Controls.Add(this.numericUpDownWeight);
            this.groupBoxOptions.Controls.Add(this.numericUpDownMaxSpeed);
            this.groupBoxOptions.Controls.Add(this.labelWeight);
            this.groupBoxOptions.Controls.Add(this.labelMaxSpeed);
            this.groupBoxOptions.Location = new System.Drawing.Point(26, 134);
            this.groupBoxOptions.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxOptions.Size = new System.Drawing.Size(242, 109);
            this.groupBoxOptions.TabIndex = 1;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Параметры";
            // 
            // checkBoxTruba
            // 
            this.checkBoxTruba.AutoSize = true;
            this.checkBoxTruba.Location = new System.Drawing.Point(157, 48);
            this.checkBoxTruba.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxTruba.Name = "checkBoxTruba";
            this.checkBoxTruba.Size = new System.Drawing.Size(56, 17);
            this.checkBoxTruba.TabIndex = 5;
            this.checkBoxTruba.Text = "Труба";
            this.checkBoxTruba.UseVisualStyleBackColor = true;
            // 
            // checkBoxKovsh
            // 
            this.checkBoxKovsh.AutoSize = true;
            this.checkBoxKovsh.Location = new System.Drawing.Point(157, 18);
            this.checkBoxKovsh.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxKovsh.Name = "checkBoxKovsh";
            this.checkBoxKovsh.Size = new System.Drawing.Size(53, 17);
            this.checkBoxKovsh.TabIndex = 4;
            this.checkBoxKovsh.Text = "Ковш";
            this.checkBoxKovsh.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(9, 78);
            this.numericUpDownWeight.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(36, 20);
            this.numericUpDownWeight.TabIndex = 3;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(9, 34);
            this.numericUpDownMaxSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(36, 20);
            this.numericUpDownMaxSpeed.TabIndex = 2;
            this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(4, 62);
            this.labelWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(26, 13);
            this.labelWeight.TabIndex = 1;
            this.labelWeight.Text = "Вес";
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.AutoSize = true;
            this.labelMaxSpeed.Location = new System.Drawing.Point(7, 18);
            this.labelMaxSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaxSpeed.Name = "labelMaxSpeed";
            this.labelMaxSpeed.Size = new System.Drawing.Size(134, 13);
            this.labelMaxSpeed.TabIndex = 0;
            this.labelMaxSpeed.Text = "Максимальная скорость";
            // 
            // pictureBoxDozer
            // 
            this.pictureBoxDozer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDozer.Location = new System.Drawing.Point(20, 19);
            this.pictureBoxDozer.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxDozer.Name = "pictureBoxDozer";
            this.pictureBoxDozer.Size = new System.Drawing.Size(269, 446);
            this.pictureBoxDozer.TabIndex = 2;
            this.pictureBoxDozer.TabStop = false;
            // 
            // panelDozer
            // 
            this.panelDozer.AllowDrop = true;
            this.panelDozer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDozer.Controls.Add(this.pictureBoxDozer);
            this.panelDozer.Location = new System.Drawing.Point(283, 10);
            this.panelDozer.Margin = new System.Windows.Forms.Padding(2);
            this.panelDozer.Name = "panelDozer";
            this.panelDozer.Size = new System.Drawing.Size(308, 484);
            this.panelDozer.TabIndex = 3;
            this.panelDozer.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelDrop_DragDrop);
            this.panelDozer.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelDrop_DragEnter);
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.labelMainColor);
            this.groupBoxColors.Controls.Add(this.labelDopColor);
            this.groupBoxColors.Controls.Add(this.panelBlue);
            this.groupBoxColors.Controls.Add(this.panelPurple);
            this.groupBoxColors.Controls.Add(this.panelGray);
            this.groupBoxColors.Controls.Add(this.panelAqua);
            this.groupBoxColors.Controls.Add(this.panelGreen);
            this.groupBoxColors.Controls.Add(this.panelYellow);
            this.groupBoxColors.Controls.Add(this.panelOrange);
            this.groupBoxColors.Controls.Add(this.panelPink);
            this.groupBoxColors.Location = new System.Drawing.Point(609, 20);
            this.groupBoxColors.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxColors.Size = new System.Drawing.Size(179, 189);
            this.groupBoxColors.TabIndex = 4;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(11, 36);
            this.labelMainColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(73, 45);
            this.labelMainColor.TabIndex = 2;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(99, 36);
            this.labelDopColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(61, 45);
            this.labelDopColor.TabIndex = 3;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(141, 154);
            this.panelBlue.Margin = new System.Windows.Forms.Padding(2);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(24, 25);
            this.panelBlue.TabIndex = 11;
            // 
            // panelPurple
            // 
            this.panelPurple.BackColor = System.Drawing.Color.Magenta;
            this.panelPurple.Location = new System.Drawing.Point(98, 153);
            this.panelPurple.Margin = new System.Windows.Forms.Padding(2);
            this.panelPurple.Name = "panelPurple";
            this.panelPurple.Size = new System.Drawing.Size(24, 25);
            this.panelPurple.TabIndex = 10;
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.Location = new System.Drawing.Point(55, 154);
            this.panelGray.Margin = new System.Windows.Forms.Padding(2);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(24, 25);
            this.panelGray.TabIndex = 9;
            // 
            // panelAqua
            // 
            this.panelAqua.BackColor = System.Drawing.Color.Aqua;
            this.panelAqua.Location = new System.Drawing.Point(11, 154);
            this.panelAqua.Margin = new System.Windows.Forms.Padding(2);
            this.panelAqua.Name = "panelAqua";
            this.panelAqua.Size = new System.Drawing.Size(24, 25);
            this.panelAqua.TabIndex = 8;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.DarkGreen;
            this.panelGreen.Location = new System.Drawing.Point(141, 115);
            this.panelGreen.Margin = new System.Windows.Forms.Padding(2);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(24, 25);
            this.panelGreen.TabIndex = 7;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(98, 114);
            this.panelYellow.Margin = new System.Windows.Forms.Padding(2);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(24, 25);
            this.panelYellow.TabIndex = 6;
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelOrange.Location = new System.Drawing.Point(55, 115);
            this.panelOrange.Margin = new System.Windows.Forms.Padding(2);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(24, 25);
            this.panelOrange.TabIndex = 5;
            // 
            // panelPink
            // 
            this.panelPink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panelPink.Location = new System.Drawing.Point(11, 115);
            this.panelPink.Margin = new System.Windows.Forms.Padding(2);
            this.panelPink.Name = "panelPink";
            this.panelPink.Size = new System.Drawing.Size(24, 25);
            this.panelPink.TabIndex = 4;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(609, 229);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(94, 28);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "Добавить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(708, 229);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(69, 28);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormCarConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 514);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.panelDozer);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.groupBoxAssembly);
            this.Controls.Add(this.groupBoxColors);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCarConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор крана";
            this.groupBoxAssembly.ResumeLayout(false);
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDozer)).EndInit();
            this.panelDozer.ResumeLayout(false);
            this.groupBoxColors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAssembly;
        private System.Windows.Forms.Label labelDozer;
        private System.Windows.Forms.Label labelCar;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelMaxSpeed;
        private System.Windows.Forms.CheckBox checkBoxKovsh;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.CheckBox checkBoxTruba;
        private System.Windows.Forms.PictureBox pictureBoxDozer;
        private System.Windows.Forms.Panel panelDozer;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelPurple;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelAqua;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelPink;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelMainColor;
    }
}