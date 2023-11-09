using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class InstrumentInform
    {
        private string instrumentType;
        private string brand;
        private string model;
        private int yearManufactured;
        private string color;


        public string InstrumentType
        {
            get => instrumentType;
            set => instrumentType = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("Значення не може бути null або пустим.");
        }

        public string Brand
        {
            get => brand;
            set => brand = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("Значення не може бути null або пустим.");
        }

        public string Model
        {
            get => model;
            set => model = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("Значення не може бути null або пустим.");
        }

        public int YearManufactured
        {
            get => yearManufactured;
            set => yearManufactured = value > 0 && value <= 2023 ? value : throw new ArgumentOutOfRangeException("Рік виготовлення не може бути від'ємним.");
        }
        public string Color
        {
            get => color;
            set => color = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("Значення не може бути null або пустим.");
        }

        public InstrumentInform(string instrumentType, string brand, string model, int yearManufactured, string color)
        {
            InstrumentType = instrumentType;
            Brand = brand;
            Model = model;
            YearManufactured = yearManufactured;
            Color = color;
        }

        public override string ToString()
        {
            return $"Type: {InstrumentType}, Brand: {Brand}, Model: {Model}, Year Manufactured: {YearManufactured}, Color: {Color}";
        }
    }
}
