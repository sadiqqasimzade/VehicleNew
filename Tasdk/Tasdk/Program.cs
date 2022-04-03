using System;
using Tasdk.Models;
using System.Reflection;
using System.Text;
namespace Tasdk
{
    class Program
    {
        static void Main()
        {
            byte choise;
            do
            {
                choise = NumberInput<byte>("1)Car\n2)Plane\n3)Bicycle\n9)End\nChoise");
                switch (choise)
                {
                    case 9: break;
                    case 1:
                        CarOptions();
                        break;
                    case 2:
                        PlaneOptions();
                        break;
                    case 3:
                        BicycleOptions();
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
            } while (choise != 9);
        }

        static void CarOptions()
        {
            byte choise;
            Console.WriteLine("You need to create car first");
            Car car = new Car(NumberInput<byte>("Door Count "), Car.VinCodeInput(), NumberInput<double>("Wheel Thickness "), NumberInput<int>("Horse power "), NumberInput<double>("Oil Tank Size "), CarFuelType(), CarTransmissionKind());
            do
            {
                choise = NumberInput<byte>("1)Create Car(Override)\n2)Add props \n3)Show Info\n4)Calculate avarange speed\n9)End\nChoise:");
                switch (choise)
                {
                    case 9: break;
                    case 1:
                        car = new Car(NumberInput<byte>("Door Count "), Car.VinCodeInput(), NumberInput<double>("Wheel Thickness "), NumberInput<ushort>("Horse power "), NumberInput<double>("Oil Tank Size "), CarFuelType(), CarTransmissionKind());
                        break;
                    case 2:
                        AddPropsToCar(car);
                        break;
                    case 3:
                        car.ShowInfo();
                        break;
                    case 4:
                        Console.WriteLine("Avarange Speed:" + car.AvarangeSpeed());
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
            } while (choise != 0);
        }

        static void PlaneOptions()
        {
            byte choise;
            Console.WriteLine("You need to create Plane first");
            Plane plane = new Plane(NumberInput<double>("Wing length"), NumberInput<int>("Horse power"), NumberInput<double>("Tank size"), PlaneFuelType(), NumberInput<double>("Wheel thickness"));
            do
            {
                choise = NumberInput<byte>("1)Create Plane(Override)\n2)Add props \n3)Show Info\n4)Calculate avarange speed\n9)End\nChoise:");
                switch (choise)
                {
                    case 9: break;
                    case 1:
                        plane = new Plane(NumberInput<double>("Wing length"), NumberInput<int>("Horse power"), NumberInput<double>("Tank size"), PlaneFuelType(), NumberInput<double>("Wheel thickness"));
                        break;
                    case 2:
                        //todo
                        break;
                    case 3:
                        plane.ShowInfo();
                        break;
                    case 4:
                        Console.WriteLine("Avarange Speed:" + plane.AvarangeSpeed());
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
            } while (choise != 0);
        }


        static void BicycleOptions()
        {
            byte choise;
            Console.WriteLine("You need to create Bicycle first");
            Bicycle bicycle = new Bicycle(PedalType(),NumberInput<double>("Wheel thickness"));
            do
            {
                choise = NumberInput<byte>("1)Create Plane(Override)\n2)Add props \n3)Show Info\n4)Calculate avarange speed\n9)End\nChoise:");
                switch (choise)
                {
                    case 9: break;
                    case 1:
                        
                        break;
                    case 2:
                        //todo
                        break;
                    case 3:
                        bicycle.ShowInfo();
                        break;
                    case 4:
                        Console.WriteLine("Avarange Speed:" + bicycle.AvarangeSpeed());
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
            } while (choise != 0);
        }
        //CarFuelType
        static string CarFuelType()
        {
            byte choise;
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var @enum in Enum.GetValues(typeof(Enums.CarFuelTypes)))
                stringBuilder.Append($"{(int)@enum}){@enum.ToString()} ");
            do
            {
                choise = NumberInput<byte>("-----------Fuel Type-----------\n" + stringBuilder + "\nChoise");
                foreach (int @enum in Enum.GetValues(typeof(Enums.CarFuelTypes)))
                    if (choise == @enum)
                        return Enum.ToObject(Enums.CarFuelTypes.Petrol.GetType(), (byte)@enum).ToString();
            } while (true);
        }

        //PlaneFuelType
        public static string PlaneFuelType()
        {
            byte choise;
            StringBuilder stringBuilder = new StringBuilder();;
            foreach (var @enum in Enum.GetValues(typeof(Enums.PlaneFuelTypes)))
                stringBuilder.Append($"{(int)@enum}){@enum.ToString()} ");

            do
            {
                choise = NumberInput<byte>("-----------Fuel-----------\n" + stringBuilder + "\nChoise");
                foreach (int @enum in Enum.GetValues(typeof(Enums.PlaneFuelTypes)))
                    if (choise == @enum)
                        return Enum.ToObject(Enums.PlaneFuelTypes.Jetfuel.GetType(), (byte)@enum).ToString();
            } while (true);
        }

        //CarTransmissionKind
        static string CarTransmissionKind()
        {
            byte choise;
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var @enum in Enum.GetValues(typeof(Enums.CarTransmissionTypes)))
                stringBuilder.Append($"{(int)@enum}){@enum.ToString()} ");
            do
            {
                choise = NumberInput<byte>("-----------Transmission-----------\n" + stringBuilder + "\nChoise");
                foreach (int @enum in Enum.GetValues(typeof(Enums.CarTransmissionTypes)))
                    if (choise == @enum)
                        return Enum.ToObject(Enums.CarTransmissionTypes.Manual.GetType(), (byte)@enum).ToString();
            } while (true);
        }

        //PedalType
        static string PedalType()
        {
            byte choise;
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var @enum in Enum.GetValues(typeof(Enums.PedalTypes)))
                stringBuilder.Append($"{(int)@enum}){@enum.ToString()} ");
            do
            {
                choise = NumberInput<byte>("-----------Pedal-----------\n" + stringBuilder + "\nChoise");
                foreach (int @enum in Enum.GetValues(typeof(Enums.PedalTypes)))
                    if (choise == @enum)
                        return Enum.ToObject(Enums.PedalTypes.Flat.GetType(), (byte)@enum).ToString();
            } while (true);
        }

        // AddPropsToCar
        static void AddPropsToCar(Car car)
        {
            double temp;
        Point1:
            try
            {
                temp = NumberInput<double>("Current Oil ");
                car.CurrentOil = temp;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Point1;
            }
        Point2:
            try
            {
                temp = NumberInput<double>("Drive Parh ");
                car.DrivePath = temp;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Point2;
            }
        Point3:
            try
            {
                temp = NumberInput<double>("Drive Time ");
                car.DriveTime = temp;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Point3;
            }
        }

        //NumberInput
        static T NumberInput<T>(string str, int min = 1)
        {
        Point:
            try
            {
                Console.Write("-----------------\n" + str + " :");
                dynamic temp = Console.ReadLine();
                temp = (T)Convert.ChangeType(temp, typeof(T));
                if (temp < min) throw new Exception($"Cant be less than {min}");
                return temp;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Point;
            }
        }
    }
}
