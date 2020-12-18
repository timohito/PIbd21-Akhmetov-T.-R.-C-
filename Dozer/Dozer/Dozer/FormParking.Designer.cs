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
            this.buttonParkTransport = new System.Windows.Forms.Button();
            this.buttonParkDozer = new System.Windows.Forms.Button();
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.groupBoxTakeCar = new System.Windows.Forms.GroupBox();
            this.buttonTake = new System.Windows.Forms.Button();
            this.maskedTextBoxForCar = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.listBoxParkings = new System.Windows.Forms.ListBox();
            this.textBoxNameOfParking = new System.Windows.Forms.TextBox();
            this.labelParkings = new System.Windows.Forms.Label();
            this.buttonAddParking = new System.Windows.Forms.Button();
            this.buttonDelParking = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBoxTakeCar.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonParkTransport
            // 
            this.buttonParkTransport.Location = new System.Drawing.Point(680, 244);
            this.buttonParkTransport.Name = "buttonParkTransport";
            this.buttonParkTransport.Size = new System.Drawing.Size(108, 47);
            this.buttonParkTransport.TabIndex = 0;
            this.buttonParkTransport.Text = "Припарковать транспорт ";
            this.buttonParkTransport.UseVisualStyleBackColor = true;
            this.buttonParkTransport.Click += new System.EventHandler(this.buttonParkTransport_Click);
            // 
            // buttonParkDozer
            // 
            this.buttonParkDozer.Location = new System.Drawing.Point(680, 297);
            this.buttonParkDozer.Name = "buttonParkDozer";
            this.buttonParkDozer.Size = new System.Drawing.Size(108, 47);
            this.buttonParkDozer.TabIndex = 1;
            this.buttonParkDozer.Text = "Припарковать бульдозер";
            this.buttonParkDozer.UseVisualStyleBackColor = true;
            this.buttonParkDozer.Click += new System.EventHandler(this.buttonParkDozer_Click);
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
            this.groupBoxTakeCar.Controls.Add(this.buttonTake);
            this.groupBoxTakeCar.Controls.Add(this.maskedTextBoxForCar);
            this.groupBoxTakeCar.Controls.Add(this.labelPlace);
            this.groupBoxTakeCar.Location = new System.Drawing.Point(680, 350);
            this.groupBoxTakeCar.Name = "groupBoxTakeCar";
            this.groupBoxTakeCar.Size = new System.Drawing.Size(108, 88);
            this.groupBoxTakeCar.TabIndex = 3;
            this.groupBoxTakeCar.TabStop = false;
            this.groupBoxTakeCar.Text = "Забрать машину";
            // 
            // buttonTake
            // 
            this.buttonTake.Location = new System.Drawing.Point(18, 60);
            this.buttonTake.Name = "buttonTake";
            this.buttonTake.Size = new System.Drawing.Size(75, 22);
            this.buttonTake.TabIndex = 2;
            this.buttonTake.Text = "Забрать";
            this.buttonTake.UseVisualStyleBackColor = true;
            this.buttonTake.Click += new System.EventHandler(this.buttonTake_Click);
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
            this.listBoxParkings.Location = new System.Drawing.Point(680, 93);
            this.listBoxParkings.Name = "listBoxParkings";
            this.listBoxParkings.Size = new System.Drawing.Size(108, 69);
            this.listBoxParkings.TabIndex = 4;
            this.listBoxParkings.SelectedIndexChanged += new System.EventHandler(this.listBoxParkings_SelectedIndexChanged);
            // 
            // textBoxNameOfParking
            // 
            this.textBoxNameOfParking.Location = new System.Drawing.Point(680, 25);
            this.textBoxNameOfParking.Name = "textBoxNameOfParking";
            this.textBoxNameOfParking.Size = new System.Drawing.Size(108, 20);
            this.textBoxNameOfParking.TabIndex = 5;
            // 
            // labelParkings
            // 
            this.labelParkings.AutoSize = true;
            this.labelParkings.Location = new System.Drawing.Point(707, 9);
            this.labelParkings.Name = "labelParkings";
            this.labelParkings.Size = new System.Drawing.Size(57, 13);
            this.labelParkings.TabIndex = 6;
            this.labelParkings.Text = "Парковки";
            // 
            // buttonAddParking
            // 
            this.buttonAddParking.Location = new System.Drawing.Point(680, 51);
            this.buttonAddParking.Name = "buttonAddParking";
            this.buttonAddParking.Size = new System.Drawing.Size(108, 36);
            this.buttonAddParking.TabIndex = 7;
            this.buttonAddParking.Text = "Добавить парковку";
            this.buttonAddParking.UseVisualStyleBackColor = true;
            this.buttonAddParking.Click += new System.EventHandler(this.buttonAddParking_Click);
            // 
            // buttonDelParking
            // 
            this.buttonDelParking.Location = new System.Drawing.Point(680, 168);
            this.buttonDelParking.Name = "buttonDelParking";
            this.buttonDelParking.Size = new System.Drawing.Size(108, 36);
            this.buttonDelParking.TabIndex = 8;
            this.buttonDelParking.Text = "Удалить парковку";
            this.buttonDelParking.UseVisualStyleBackColor = true;
            this.buttonDelParking.Click += new System.EventHandler(this.buttonDelParking_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDelParking);
            this.Controls.Add(this.buttonAddParking);
            this.Controls.Add(this.labelParkings);
            this.Controls.Add(this.textBoxNameOfParking);
            this.Controls.Add(this.listBoxParkings);
            this.Controls.Add(this.groupBoxTakeCar);
            this.Controls.Add(this.pictureBoxParking);
            this.Controls.Add(this.buttonParkDozer);
            this.Controls.Add(this.buttonParkTransport);
            this.Name = "FormParking";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxTakeCar.ResumeLayout(false);
            this.groupBoxTakeCar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonParkTransport;
        private System.Windows.Forms.Button buttonParkDozer;
        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.GroupBox groupBoxTakeCar;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Button buttonTake;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxForCar;
        private System.Windows.Forms.ListBox listBoxParkings;
        private System.Windows.Forms.TextBox textBoxNameOfParking;
        private System.Windows.Forms.Label labelParkings;
        private System.Windows.Forms.Button buttonAddParking;
        private System.Windows.Forms.Button buttonDelParking;
    }
}