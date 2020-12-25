using System;
using System.Drawing;
using System.Windows.Forms;


namespace Dozer
{
    public partial class FormParking : Form
    {
        private readonly ParkingCollection parkingCollection;

        public FormParking()
        {
            InitializeComponent();
            parkingCollection = new ParkingCollection(pictureBoxParking.Width, pictureBoxParking.Height);
        }

        private void ReloadLevels()
        {
            int index = listBoxParkings.SelectedIndex;
            listBoxParkings.Items.Clear();
            for (int i = 0; i < parkingCollection.Keys.Count; i++)
            {
                listBoxParkings.Items.Add(parkingCollection.Keys[i]);
            }
            if (listBoxParkings.Items.Count > 0 && (index == -1 || index >=
           listBoxParkings.Items.Count))
            {
                listBoxParkings.SelectedIndex = 0;
            }
            else if (listBoxParkings.Items.Count > 0 && index > -1 && index <
           listBoxParkings.Items.Count)
            {
                listBoxParkings.SelectedIndex = index;
            }
        }

        private void Draw()
        {
            if (listBoxParkings.SelectedIndex > -1)
            {//если выбран один из пуктов в listBox (при старте программы ни один пункт не будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементуlistBox)
                Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parkingCollection[listBoxParkings.SelectedItem.ToString()].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }

        private void listBoxParkings_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
		
		private void buttonAddParking_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNameOfParking.Text))
            {
                MessageBox.Show("Введите название парковки", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            parkingCollection.AddParking(textBoxNameOfParking.Text);
            ReloadLevels();
        }

        private void buttonSetCar_Click(object sender, EventArgs e)
        {
            var formCarConfig = new FormCarConfig();
            formCarConfig.AddEvent(AddCar);
            formCarConfig.Show();
        }

        private void AddCar(Vehicle car)
        {
            if (car != null && listBoxParkings.SelectedIndex > -1)
            {
                if ((parkingCollection[listBoxParkings.SelectedItem.ToString()]) + car)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Машину не удалось поставить");
                }
            }
        }

        private void buttonTakeCar_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1 && maskedTextBoxForCar.Text != "")
            {
                var car = parkingCollection[listBoxParkings.SelectedItem.ToString()] -
		Convert.ToInt32(maskedTextBoxForCar.Text);
                if (car != null)
                {
                    FormDozer form = new FormDozer();
                    form.SetCar(car);
                    form.ShowDialog();
                }
                Draw();
            }
        }

        private void buttonDelParking_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить парковку{ listBoxParkings.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    parkingCollection.DelParking(listBoxParkings.SelectedItem.ToString());
                    ReloadLevels();
                }
            }
        }
    }
}

