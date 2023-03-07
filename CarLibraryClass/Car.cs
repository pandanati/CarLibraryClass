using System;

namespace CarLibraryClass
{
    public class Car
    {
        private double _price;
        private string _licensePlate;
        private string _model;
        public int Id { get; set; }

        public string Model
        {
            get { return _model; }
            set
            {
                if (value.Length < 4)
                {
                    throw new Exception("Length of the model has to be greater than 4.");
                }
                else
                {
                    _model = value;
                }
            }
        }

        public double Price
        {
            get { return _price; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Price has to be more than 0");
                }
                else
                {
                    _price = value;
                }
            }
        }

        public string LicensePlate
        {
            get { return _licensePlate; }
            set
            {
                if ((value.Length < 2) || (value.Length > 7))
                {
                    throw new Exception("The License Plate has to be between 2 and 7 characters");
                }
                else
                {
                    _licensePlate = value;
                }
            }
        }
    }
}
