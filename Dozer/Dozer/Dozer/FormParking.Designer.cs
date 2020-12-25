namespace Dozer
{
    partial class FormParking
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.groupBoxTakeCar = new System.Windows.Forms.GroupBox();
            this.buttonTakeCar = new System.Windows.Forms.Button();
            this.maskedTextBoxForCar = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.listBoxParkings = new System.Windows.Forms.ListBox();
            this.textBoxNameOfParking = new System.Windows.Forms.TextBox();
            this.labelParkings = new System.Windows.Forms.Label();
            this.buttonAddParking = new System.Windows.Forms.Button();
            this.buttonDelParking = new System.Windows.Forms.Button();
            this.buttonSetCar = new System.Windows.Forms.Button();
            this.menuDozer = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialogDozer = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogDozer = new System.Windows.Forms.OpenFileDialog();
            this.buttonSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBoxTakeCar.SuspendLayout();
            this.menuDozer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(-1, -1);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(675, 454);
            this.pictureBoxParking.TabIndex = 2;
            this.pictureBoxParking.TabStop = false;
            // 
            // groupBoxTakeCar
            // 
            this.groupBoxTakeCar.Controls.Add(this.buttonTakeCar);
            this.groupBoxTakeCar.Controls.Add(this.maskedTextBoxForCar);
            this.groupBoxTakeCar.Controls.Add(this.labelPlace);
            this.groupBoxTakeCar.Location = new System.Drawing.Point(680, 350);
            this.groupBoxTakeCar.Name = "groupBoxTakeCar";
            this.groupBoxTakeCar.Size = new System.Drawing.Size(108, 88);
            this.groupBoxTakeCar.TabIndex = 3;
            this.groupBoxTakeCar.TabStop = false;
            this.groupBoxTakeCar.Text = "Забрать машину";
            // 
            // buttonTakeCar
            // 
            this.buttonTakeCar.Location = new System.Drawing.Point(18, 60);
            this.buttonTakeCar.Name = "buttonTakeCar";
            this.buttonTakeCar.Size = new System.Drawing.Size(75, 22);
            this.buttonTakeCar.TabIndex = 2;
            this.buttonTakeCar.Text = "Забрать";
            this.buttonTakeCar.UseVisualStyleBackColor = true;
            this.buttonTakeCar.Click += new System.EventHandler(this.buttonTakeCar_Click);
            // 
            // maskedTextBoxForCar
            // 
            this.maskedTextBoxForCar.Location = new System.Drawing.Point(66, 22);
            this.maskedTextBoxForCar.Name = "maskedTextBoxForCar";
            this.maskedTextBoxForCar.Size = new System.Drawing.Size(27, 20);
            this.maskedTextBoxForCar.TabIndex = 1;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(18, 25);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(42, 13);
            this.labelPlace.TabIndex = 0;
            this.labelPlace.Text = "Место:";
            // 
            // listBoxParkings
            // 
            this.listBoxParkings.FormattingEnabled = true;
            this.listBoxParkings.Location = new System.Drawing.Point(680, 122);
            this.listBoxParkings.Name = "listBoxParkings";
            this.listBoxParkings.Size = new System.Drawing.Size(108, 69);
            this.listBoxParkings.TabIndex = 4;
            this.listBoxParkings.SelectedIndexChanged += new System.EventHandler(this.listBoxParkings_SelectedIndexChanged);
            // 
            // textBoxNameOfParking
            // 
            this.textBoxNameOfParking.Location = new System.Drawing.Point(680, 54);
            this.textBoxNameOfParking.Name = "textBoxNameOfParking";
            this.textBoxNameOfParking.Size = new System.Drawing.Size(108, 20);
            this.textBoxNameOfParking.TabIndex = 5;
            // 
            // labelParkings
            // 
            this.labelParkings.AutoSize = true;
            this.labelParkings.Location = new System.Drawing.Point(698, 38);
            this.labelParkings.Name = "labelParkings";
            this.labelParkings.Size = new System.Drawing.Size(57, 13);
            this.labelParkings.TabIndex = 6;
            this.labelParkings.Text = "Парковки";
            // 
            // buttonAddParking
            // 
            this.buttonAddParking.Location = new System.Drawing.Point(680, 80);
            this.buttonAddParking.Name = "buttonAddParking";
            this.buttonAddParking.Size = new System.Drawing.Size(108, 36);
            this.buttonAddParking.TabIndex = 7;
            this.buttonAddParking.Text = "Добавить парковку";
            this.buttonAddParking.UseVisualStyleBackColor = true;
            this.buttonAddParking.Click += new System.EventHandler(this.buttonAddParking_Click);
            // 
            // buttonDelParking
            // 
            this.buttonDelParking.Location = new System.Drawing.Point(680, 197);
            this.buttonDelParking.Name = "buttonDelParking";
            this.buttonDelParking.Size = new System.Drawing.Size(108, 36);
            this.buttonDelParking.TabIndex = 8;
            this.buttonDelParking.Text = "Удалить парковку";
            this.buttonDelParking.UseVisualStyleBackColor = true;
            this.buttonDelParking.Click += new System.EventHandler(this.buttonDelParking_Click);
            // 
            // buttonSetCar
            // 
            this.buttonSetCar.Location = new System.Drawing.Point(680, 289);
            this.buttonSetCar.Name = "buttonSetCar";
            this.buttonSetCar.Size = new System.Drawing.Size(108, 43);
            this.buttonSetCar.TabIndex = 9;
            this.buttonSetCar.Text = "Добавить автомобиль";
            this.buttonSetCar.UseVisualStyleBackColor = true;
            this.buttonSetCar.Click += new System.EventHandler(this.buttonSetCar_Click);
            // 
            // menuDozer
            // 
            this.menuDozer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuDozer.Location = new System.Drawing.Point(0, 0);
            this.menuDozer.Name = "menuDozer";
            this.menuDozer.Size = new System.Drawing.Size(800, 24);
            this.menuDozer.TabIndex = 11;
            this.menuDozer.Text = "menuStripDozer";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // saveFileDialogDozer
            // 
            this.saveFileDialogDozer.Filter = "txt file | *.txt";
            // 
            // openFileDialogDozer
            // 
            this.openFileDialogDozer.FileName = "openFileDialogDozer";
            this.openFileDialogDozer.Filter = "txt file | *.txt";
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(680, 239);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(108, 44);
            this.buttonSort.TabIndex = 12;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.menuDozer);
            this.Controls.Add(this.buttonSetCar);
            this.Controls.Add(this.buttonDelParking);
            this.Controls.Add(this.buttonAddParking);
            this.Controls.Add(this.labelParkings);
            this.Controls.Add(this.textBoxNameOfParking);
            this.Controls.Add(this.listBoxParkings);
            this.Controls.Add(this.groupBoxTakeCar);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxTakeCar.ResumeLayout(false);
            this.groupBoxTakeCar.PerformLayout();
            this.menuDozer.ResumeLayout(false);
            this.menuDozer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.GroupBox groupBoxTakeCar;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Button buttonTakeCar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxForCar;
		private System.Windows.Forms.ListBox listBoxParkings;
		private System.Windows.Forms.TextBox textBoxNameOfParking;
		private System.Windows.Forms.Label labelParkings;
		private System.Windows.Forms.Button buttonAddParking;
		private System.Windows.Forms.Button buttonDelParking;
		private System.Windows.Forms.Button buttonSetCar;
        private System.Windows.Forms.MenuStrip menuDozer;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialogDozer;
        private System.Windows.Forms.OpenFileDialog openFileDialogDozer;
        private System.Windows.Forms.Button buttonSort;
    }
}