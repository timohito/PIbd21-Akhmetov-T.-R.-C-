using System;
using System.Drawing;
using System.Windows.Forms;


namespace Dozer
{
    public partial class FormParking : Form
    {
        private readonly Parking<Car> parking;

        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<Car>(pictureBoxParking.Width, pictureBoxParking.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }

        private void buttonTake_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxForCar.Text != "")
            {
                var car = parking - Convert.ToInt32(maskedTextBoxForCar.Text);
                if (car != null)
                {
                    FormDozer form = new FormDozer();
                    form.SetCar(car);
                    form.ShowDialog();
                }
                Draw();
            }
        }

        private void buttonParkTransport_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var car = new Car(100, 1000, dialog.Color);

                if (parking + car)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Парковка переполнена");
                }
            }
        }

        private void buttonParkDozer_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var car = new Dozer(100, 1000, dialog.Color, dialogDop.Color, true, true);
                    if (parking + car)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Парковка переполнена");
                    }
                }
            }
        }
    }
}

