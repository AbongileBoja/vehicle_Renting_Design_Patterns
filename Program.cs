using Vehicle_Renting_Patterns.Abstract;
using Vehicle_Renting_Patterns.Classes;

namespace Vehicle_Renting_Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select vehicle type:");
            Console.WriteLine("1. Motorcycle");
            Console.WriteLine("2. Light Motor Vehicle");
            Console.WriteLine("3. Heavy Motor Vehicle");
            Console.WriteLine("4. Custom Vehicle");
            int option = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Vehicle vehicle = null;
            Technician feature = null;
            if (option == 1)
            {
                vehicle = new Motorcycle();
                feature = new TechMotorcycle();
            }
            else if (option == 2)
            {
                vehicle = new LightVehicle();
                feature = new TechLightVehicle();
            }
            else if (option == 3)
            {
                vehicle = new HeavydutyVehicle();
                feature = new TechHeavydutyVehicle();
            }
            else if (option == 4)
            {
                int carrier, engine, tow;
                CarrierOption();
                carrier = int.Parse(Console.ReadLine());
                if (carrier == 1)
                {
                    Engine();
                    engine = int.Parse(Console.ReadLine());
                    if (engine == 1)
                    {
                        Tow();
                        tow = int.Parse(Console.ReadLine());
                        if (tow == 1)
                        {
                            vehicle = new CustomVehicle(new CarrierOption1(), new SmallEngine(), new CanTow());
                            feature = new TechCustomVehicle();
                        }
                        else if (tow == 2)
                        {
                            vehicle = new CustomVehicle(new CarrierOption1(), new SmallEngine(), new NoTow());
                            feature = new TechCustomVehicle();
                        }
                    }
                    else if (engine == 2)
                    {
                        Tow();
                        tow = int.Parse(Console.ReadLine());
                        if (tow == 1)
                        {
                            vehicle = new CustomVehicle(new CarrierOption1(), new SmallEngine(), new CanTow());
                            feature = new TechCustomVehicle();
                        }
                        else if (tow == 2)
                        {
                            vehicle = new CustomVehicle(new CarrierOption1(), new SmallEngine(), new NoTow());
                            feature = new TechCustomVehicle();
                        }
                    }
                    else if (engine == 3)
                    {
                        Tow();
                        tow = int.Parse(Console.ReadLine());
                        if (tow == 1)
                        {
                            vehicle = new CustomVehicle(new CarrierOption1(), new MediumEngine(), new CanTow());
                            feature = new TechCustomVehicle();

                        }
                        else if (tow == 2)
                        {
                            vehicle = new CustomVehicle(new CarrierOption1(), new MediumEngine(), new NoTow());
                            feature = new TechCustomVehicle();
                        }
                    }
                    else if (engine == 4)
                    {
                        Tow();
                        tow = int.Parse(Console.ReadLine());
                        if (tow == 1)
                        {
                            vehicle = new CustomVehicle(new CarrierOption1(), new LargeEngine(), new CanTow());
                            feature = new TechCustomVehicle();
                        }
                        else if (tow == 2)
                        {
                            vehicle = new CustomVehicle(new CarrierOption1(), new LargeEngine(), new NoTow());
                            feature = new TechCustomVehicle();
                        }
                    }
                }
                else if (carrier == 2)
                {
                    Engine();
                    engine = int.Parse(Console.ReadLine());
                    if (engine == 1)
                    {
                        Tow();
                        tow = int.Parse(Console.ReadLine());
                        if (tow == 1)
                        {
                            vehicle = new CustomVehicle(new CarrierOption2(), new SmallEngine(), new CanTow());
                            feature = new TechCustomVehicle();
                        }
                        else if (tow == 2)
                        {
                            vehicle = new CustomVehicle(new CarrierOption2(), new SmallEngine(), new NoTow());
                            feature = new TechCustomVehicle();
                        }
                    }
                    else if (engine == 2)
                    {
                        Tow();
                        tow = int.Parse(Console.ReadLine());
                        if (tow == 1)
                        {
                            vehicle = new CustomVehicle(new CarrierOption2(), new SmallEngine(), new CanTow());
                            feature = new TechCustomVehicle();
                        }
                        else if (tow == 2)
                        {
                            vehicle = new CustomVehicle(new CarrierOption2(), new SmallEngine(), new NoTow());
                            feature = new TechCustomVehicle();
                        }
                    }
                    else if (engine == 3)
                    {
                        Tow();
                        tow = int.Parse(Console.ReadLine());
                        if (tow == 1)
                        {
                            vehicle = new CustomVehicle(new CarrierOption2(), new MediumEngine(), new CanTow());
                            feature = new TechCustomVehicle();
                        }
                        else if (tow == 2)
                        {
                            vehicle = new CustomVehicle(new CarrierOption2(), new MediumEngine(), new NoTow());
                            feature = new TechCustomVehicle();
                        }
                    }
                    else if (engine == 4)
                    {
                        Tow();
                        tow = int.Parse(Console.ReadLine());
                        if (tow == 1)
                        {
                            vehicle = new CustomVehicle(new CarrierOption2(), new LargeEngine(), new CanTow());
                            feature = new TechCustomVehicle();
                        }
                        else if (tow == 2)
                        {
                            vehicle = new CustomVehicle(new CarrierOption2(), new LargeEngine(), new NoTow());
                            feature = new TechCustomVehicle();
                        }
                    }
                }
                else if (carrier == 3)
                {
                    Engine();
                    engine = int.Parse(Console.ReadLine());
                    if (engine == 1)
                    {
                        Tow();
                        tow = int.Parse(Console.ReadLine());
                        if (tow == 1)
                        {
                            vehicle = new CustomVehicle(new CarrierOption3(), new SmallEngine(), new CanTow());
                            feature = new TechCustomVehicle();
                        }
                        else if (tow == 2)
                        {
                            vehicle = new CustomVehicle(new CarrierOption3(), new SmallEngine(), new NoTow());
                            feature = new TechCustomVehicle();
                        }
                    }
                    else if (engine == 2)
                    {
                        Tow();
                        tow = int.Parse(Console.ReadLine());
                        if (tow == 1)
                        {
                            vehicle = new CustomVehicle(new CarrierOption3(), new SmallEngine(), new CanTow());
                            feature = new TechCustomVehicle();
                        }
                        else if (tow == 2)
                        {
                            vehicle = new CustomVehicle(new CarrierOption3(), new SmallEngine(), new NoTow());
                            feature = new TechCustomVehicle();
                        }
                    }
                    else if (engine == 3)
                    {
                        Tow();
                        tow = int.Parse(Console.ReadLine());
                        if (tow == 1)
                        {
                            vehicle = new CustomVehicle(new CarrierOption3(), new MediumEngine(), new CanTow());
                            feature = new TechCustomVehicle();
                        }
                        else if (tow == 2)
                        {
                            vehicle = new CustomVehicle(new CarrierOption3(), new MediumEngine(), new NoTow());
                            feature = new TechCustomVehicle();
                        }
                    }
                    else if (engine == 4)
                    {
                        Tow();
                        tow = int.Parse(Console.ReadLine());
                        if (tow == 1)
                        {
                            vehicle = new CustomVehicle(new CarrierOption3(), new LargeEngine(), new CanTow());
                            feature = new TechCustomVehicle();
                        }
                        else if (tow == 2)
                        {
                            vehicle = new CustomVehicle(new CarrierOption3(), new LargeEngine(), new NoTow());
                            feature = new TechCustomVehicle();
                        }
                    }
                }
                else if (carrier == 4)
                {

                    Engine();
                    engine = int.Parse(Console.ReadLine());
                    if (engine == 1)
                    {
                        Tow();
                        tow = int.Parse(Console.ReadLine());
                        if (tow == 1)
                        {
                            vehicle = new CustomVehicle(new CarrierOption4(), new SmallEngine(), new CanTow());
                            feature = new TechCustomVehicle();
                        }
                        else if (tow == 2)
                        {
                            vehicle = new CustomVehicle(new CarrierOption4(), new SmallEngine(), new NoTow());
                            feature = new TechCustomVehicle();
                        }
                    }
                    else if (engine == 2)
                    {
                        Tow();
                        tow = int.Parse(Console.ReadLine());
                        if (tow == 1)
                        {
                            vehicle = new CustomVehicle(new CarrierOption4(), new SmallEngine(), new CanTow());
                            feature = new TechCustomVehicle();
                        }
                        else if (tow == 2)
                        {
                            vehicle = new CustomVehicle(new CarrierOption4(), new SmallEngine(), new NoTow());
                            feature = new TechCustomVehicle();
                        }
                    }
                    else if (engine == 3)
                    {
                        Tow();
                        tow = int.Parse(Console.ReadLine());
                        if (tow == 1)
                        {
                            vehicle = new CustomVehicle(new CarrierOption4(), new MediumEngine(), new CanTow());
                            feature = new TechCustomVehicle();
                        }
                        else if (tow == 2)
                        {
                            vehicle = new CustomVehicle(new CarrierOption4(), new MediumEngine(), new NoTow());
                            feature = new TechCustomVehicle();
                        }
                    }
                    else if (engine == 4)
                    {
                        Tow();
                        tow = int.Parse(Console.ReadLine());
                        if (tow == 1)
                        {
                            vehicle = new CustomVehicle(new CarrierOption1(), new LargeEngine(), new CanTow());
                            feature = new TechCustomVehicle();
                        }
                        else if (tow == 2)
                        {
                            vehicle = new CustomVehicle(new CarrierOption1(), new LargeEngine(), new NoTow());
                            feature = new TechCustomVehicle();
                        }
                    }
                }
                else if (carrier == 5)
                {
                    Engine();
                    engine = int.Parse(Console.ReadLine());
                    if (engine == 1)
                    {
                        Tow();
                        tow = int.Parse(Console.ReadLine());
                        if (tow == 1)
                        {
                            vehicle = new CustomVehicle(new CarrierOption5(), new SmallEngine(), new CanTow());
                            feature = new TechCustomVehicle();
                        }
                        else if (tow == 2)
                        {
                            vehicle = new CustomVehicle(new CarrierOption5(), new SmallEngine(), new NoTow());
                            feature = new TechCustomVehicle();
                        }
                    }
                    else if (engine == 2)
                    {
                        Tow();
                        tow = int.Parse(Console.ReadLine());
                        if (tow == 1)
                        {
                            vehicle = new CustomVehicle(new CarrierOption5(), new SmallEngine(), new CanTow());
                            feature = new TechCustomVehicle();
                        }
                        else if (tow == 2)
                        {
                            vehicle = new CustomVehicle(new CarrierOption5(), new SmallEngine(), new NoTow());
                            feature = new TechCustomVehicle();
                        }
                    }
                    else if (engine == 3)
                    {
                        Tow();
                        tow = int.Parse(Console.ReadLine());
                        if (tow == 1)
                        {
                            vehicle = new CustomVehicle(new CarrierOption5(), new MediumEngine(), new CanTow());
                            feature = new TechCustomVehicle();
                        }
                        else if (tow == 2)
                        {
                            vehicle = new CustomVehicle(new CarrierOption5(), new MediumEngine(), new NoTow());
                            feature = new TechCustomVehicle();
                        }
                    }
                    else if (engine == 4)
                    {
                        Tow();
                        tow = int.Parse(Console.ReadLine());
                        if (tow == 1)
                        {
                            vehicle = new CustomVehicle(new CarrierOption1(), new LargeEngine(), new CanTow());
                            feature = new TechCustomVehicle();
                        }
                        else if (tow == 2)
                        {
                            vehicle = new CustomVehicle(new CarrierOption1(), new LargeEngine(), new NoTow());
                            feature = new TechCustomVehicle();
                        }
                    }
                }
            }

            Console.WriteLine(vehicle.Name);
            Console.WriteLine("Carrier Capabilities:");
            vehicle.CarrierOption();
            Console.WriteLine();
            Console.WriteLine("Engine:");
            vehicle.Engine();
            Console.WriteLine();
            Console.WriteLine("Tow Capabilities:");
            vehicle.VehicleTow();
            Console.WriteLine();

            Console.WriteLine("Incude camera system (y/n): ");
            char camera = char.Parse(Console.ReadLine());
            if (camera == 'y')
            {
                feature = new Camera(feature);
            }
            else if (camera == 'n') { }
            Console.WriteLine("Incude WiFi (y/n): ");
            char wifi = char.Parse(Console.ReadLine());
            if (wifi == 'y')
            {
                feature = new Wifi(feature);
            }
            else if (wifi == 'n') { }

            Console.WriteLine("Incude Sound Sytem (y/n): ");
            char soundSystem = char.Parse(Console.ReadLine());
            if (soundSystem == 'y')
            {
                feature = new SoundSystem(feature);
            }
            else if (soundSystem == 'n') { }

            Console.WriteLine();
            Console.WriteLine(feature.FeatureDescription());

            if (option == 1)
            {
                TechMotorcycle subject = new TechMotorcycle();
                subject.Attach(new Motorcycle(subject));
                subject.setState(feature.Cost());
            }
            else if (option == 2)
            {
                TechLightVehicle subject = new TechLightVehicle();
                subject.Attach(new LightVehicle(subject));
                subject.setState(feature.Cost());
            }
            else if (option == 3)
            {
                TechHeavydutyVehicle subject = new TechHeavydutyVehicle();
                subject.Attach(new HeavydutyVehicle(subject));
                subject.setState(feature.Cost());
            }
            else if (option == 4)
            {
                TechCustomVehicle subject = new TechCustomVehicle();
                subject.Attach(new CustomVehicle(subject));
                subject.setState(feature.Cost());
            }
            Console.ReadLine();
        }
        public static void CarrierOption()
        {
            Console.WriteLine("Select Carrier Option");
            Console.WriteLine("1. Carrier Capability - Good and Driver");
            Console.WriteLine("2. Carrier Capability - 2 people max, and bag");
            Console.WriteLine("3. Carrier Capability - 5 people and few luggage");
            Console.WriteLine("4. Carrier Capability - 20 people max");
            Console.WriteLine("5. Carrier Capability - 65 people max");
            Console.WriteLine();
        }
        public static void Engine()
        {
            Console.WriteLine("Select Engine Option");
            Console.WriteLine("1. Engine - Small");
            Console.WriteLine("2. Engine - Medium");
            Console.WriteLine("3. Engine - Large");
            Console.WriteLine("4. Engine - Extra Large");
            Console.WriteLine();
        }
        public static void Tow()
        {
            Console.WriteLine("Select Tow Option");
            Console.WriteLine("1. Tow - Can Tow");
            Console.WriteLine("2. Tow - Cannot Tow");
            Console.WriteLine();
        }
    }
  
}
