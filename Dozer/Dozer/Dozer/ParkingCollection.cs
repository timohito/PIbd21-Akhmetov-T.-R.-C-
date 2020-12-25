using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Dozer
{
    public class ParkingCollection
    {
        readonly Dictionary<string, Parking<Vehicle>> parkingStages;

        public List<string> Keys => parkingStages.Keys.ToList();

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        private readonly char separator = ':';

        public ParkingCollection(int pictureWidth, int pictureHeight)
        {
            parkingStages = new Dictionary<string, Parking<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        public void AddParking(string name)
        {
            if (parkingStages.Keys.Contains(name)) { return; }

            parkingStages.Add(name, new Parking<Vehicle>(pictureWidth, pictureHeight));
        }

        public void DelParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                parkingStages.Remove(name);
            }
        }

        public Parking<Vehicle> this[string ind]
        {

            get
            {
                if (!parkingStages.ContainsKey(ind))
                {
                    return null;
                }
                return parkingStages[ind];
            }

        }

        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine($"ParkingCollection");
                foreach (var level in parkingStages)
                {
                    //Начинаем парковку
                    sw.WriteLine($"Parking{separator}{level.Key}");
                    ITransport car = null;
                    for (int i = 0; (car = level.Value.GetNext(i)) != null; i++)
                    {
                        if (car != null)
                        {
                            //если место не пустое
                            //Записываем тип машины
                            if (car.GetType().Name == "Car")
                            {
                                sw.Write($"Car{separator}");
                            }
                            if (car.GetType().Name == "Dozer")
                            {
                                sw.Write($"Dozer{separator}");
                            }
                            //Записываемые параметры
                            sw.WriteLine(car);
                        }
                    }
                }
            }
        }

        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            using (StreamReader sr = new StreamReader(filename))
            {
                bool head = true;
                string line;
                Vehicle car = null;
                string key = string.Empty;
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.Replace("\r", "");
                    if (head)
                    {
                        if (line.Contains("ParkingCollection"))
                        {
                            //очищаем записи
                            parkingStages.Clear();
                            head = false;
                        }
                        else
                        {
                            //если нет такой записи, то это не те данные
                            throw new FormatException("Неверный формат файла");
                        }
                    }
                    else
                    {
                        //идем по считанным записям
                        if (line.Contains("Parking"))
                        {//начинаем новую парковку
                            key = line.Split(separator)[1];
                            parkingStages.Add(key, new Parking<Vehicle>(pictureWidth, pictureHeight));
                            continue;
                        }
                        if (string.IsNullOrEmpty(line))
                        {
                            continue;
                        }
                        if (line.Split(separator)[0] == "Car")
                        {
                            car = new Car(line.Split(separator)[1]);
                        }
                        else if (line.Split(separator)[0] == "Dozer")
                        {
                            car = new Dozer(line.Split(separator)[1]);
                        }
                        var result = parkingStages[key] + car;
                        if (!result)
                        {
                            throw new OverflowException("Не удалось загрузить машину на парковку");
                        }
                    }
                }
            }
        }
    }
}
