namespace OOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region theoritical questions

            //            /** Q1.
            //             * a.Abstraction is hiding complex implementation details and exposing only the essential features of an object using abstract classes and interfaces.
            //             * b.It reduces code complexity, enhances maintainability, and enforces contracts across derived classes.  
            //             * 
            //             * Q2.
            //             * a. abstract class:"IS-A" inheritance relationship, Not supported (single inheritance only) ,Can hold fields, constructors, and full method implementations.
            //             *    interface:"CAN-DO" contract / capability,Supported (a class can implement multiple interfaces),Holds method and property signatures only (no fields or constructors)
            //             * b.Choose an interface when defining a shared contract across unrelated classes, or when multiple inheritance of capabilities is required.
            //             * c.No, C# does not support inheriting from multiple abstract classes. Yes, a class can implement multiple interfaces.
            //             * 
            //             * 
            //             * 
            //             * */
            #endregion
            // a. Create one StandardShipment
            StandardShipment s1 = new StandardShipment("SH001", "Laptop", 5, 80, new DeliveryAddress("Cairo", "Street 1", 12345));

            // b. Create one ExpressShipment
            ExpressShipment e1 = new ExpressShipment("SH002", "Mobile Phone", 2, 60, new DeliveryAddress("Giza", "Street 2", 54321), 30);

            // c. Create one InternationalShipment
            InterNationalShipment i1 = new InterNationalShipment("SH003", "Television", 8, 100, new DeliveryAddress("Alexandria", "Street 3", 99999), "Germany", 80);

            // d. Add all shipments to DeliveryCenter
            DeliveryCenter center = new DeliveryCenter();
            center.AddShipment(s1);
            center.AddShipment(e1);
            center.AddShipment(i1);

            // e. Print all shipment details
            Console.WriteLine("==========================================");
            Console.WriteLine("Delivery Center");
            Console.WriteLine("==========================================");
            Console.WriteLine();

            s1.PrintShipment();
            Console.WriteLine("\n------------------------------------------\n");
            e1.PrintShipment();
            Console.WriteLine("\n------------------------------------------\n");
            i1.PrintShipment();
            Console.WriteLine();

            // f. Print tracking status of every shipment
            center.PrintTrackingStatuses();

            // g. Print insurance cost of every shipment
            Console.WriteLine("==========================================");
            Console.WriteLine("Insurance\n");
            Console.WriteLine($"Standard Shipment Insurance : {s1.CalculateInsurance():0.00} EGP\n");
            Console.WriteLine($"Express Shipment Insurance : {e1.CalculateInsurance():0.00} EGP\n");
            Console.WriteLine($"International Shipment Insurance : {i1.CalculateInsurance():0.00} EGP\n");

            // h. Store in ITrackable[] array and print tracking statuses
            ITrackable[] trackables = new ITrackable[] { s1, e1, i1 };

            // i. Store in IInsurable[] array and print insurance values
            IInsurable[] insurables = new IInsurable[] { s1, e1, i1 };

            Console.WriteLine("==========================================");
            Console.WriteLine("Interface Polymorphism Demonstrated Successfully.");

            //            Driver driver = new Driver(330, "amgad mohamed", 010658722);
            //            DeliveryCenter deliveryCenter = new DeliveryCenter();
            //            deliveryCenter.driver = driver;
            //            StandardShipment s1 = new StandardShipment("hh556", "eyeshadow", 5, 35, new DeliveryAddress("giza", "mohamed salim", 26));
            //            ExpressShipment e1 = new ExpressShipment("hd557", "highlighter", 7, 30, new DeliveryAddress("cairo", "alaaeldin", 12), 10);
            //            InterNationalShipment i1 = new InterNationalShipment("dd558", "foundation", 10, 20, new DeliveryAddress("helwan", "sakr", 22), 15);
            //            deliveryCenter.AddShipment(s1);
            //            deliveryCenter.AddShipment(e1);
            //            deliveryCenter.AddShipment(i1);
            //            Console.WriteLine("------------------------------------------");
            //            Console.WriteLine("--------------all shipments---------------");
            //            Console.WriteLine("------------------------------------------");
            //            deliveryCenter.PrintAllShipments();

            //            //print using deliveryhelper
            //            Console.WriteLine("print by deliveryhelper");
            //            DeliveryHelper.PrintShipmentDetails(s1);
            //            DeliveryHelper.PrintShipmentDetails(e1);
            //            DeliveryHelper.PrintShipmentDetails(i1);

            //            //updating weight
            //            Console.Write("-------update weight--------");
            //            //before update
            //            Console.Write($"the original weight is : {s1.Weight}");
            //            // 1st update
            //            s1.UpdateWeight(12);
            //            Console.Write($"updated weight: {s1.Weight}");
            //            //2nd update 
            //            s1.UpdateWeight(10, 5);
            //            Console.Write($"updated weight after packing fee:{s1.Weight} ");

            //            //printing using shipment[]
            //            Console.Write("------- printing using shipment--------");
            //            CompletedShipment c1 = new CompletedShipment("266", "books", 100, 20, new DeliveryAddress("sharkia", "mohamed ali", 51));
            //            Shipment[] shipmenttypes = new Shipment[] { s1, e1, i1, };
            //            foreach (var Shipment in shipmenttypes)
            //            {
            //                Shipment.PrintShipment();
            //            }

            //            //sealed class and methods
            //            Console.Write("-------sealed class and methods --------");
            //            PriorityInternationalShipment pis = new PriorityInternationalShipment("200", "laptop", 500, 40, new DeliveryAddress("cairo", "esmael shehata", 2), 20);
            //            Console.WriteLine(pis.GenerateCustomsReport);
            //            DeliveryCenter center = new DeliveryCenter();
            //            Console.Write("enter delivery center name: ");
            //            string centername = Console.ReadLine();
            //            Console.WriteLine();
            //            //standard shipment



            //            Console.WriteLine($"--- Enter Shipment 1  Data  Standard Shipment---");

            //            Console.Write("TrackingCode: ");
            //            string trackingCode1 = Console.ReadLine();

            //            Console.Write("Description: ");
            //            string description1 = Console.ReadLine();

            //            Console.Write("Weight: ");
            //            decimal weight1;
            //            while (!decimal.TryParse(Console.ReadLine(), out weight1))
            //            {
            //                Console.Write("Invalid input, enter Weight again: ");
            //            }

            //            Console.Write("DeliveryFee: ");
            //            decimal fee1;
            //            while (!decimal.TryParse(Console.ReadLine(), out fee1))
            //            {
            //                Console.Write("Invalid input, enter DeliveryFee again: ");
            //            }

            //            Console.Write("City: ");
            //            string city1 = Console.ReadLine();

            //            Console.Write("Street: ");
            //            string street1 = Console.ReadLine();

            //            Console.Write("Building Number: ");
            //            int buildingNum1;
            //            while (!int.TryParse(Console.ReadLine(), out buildingNum1))
            //            {
            //                Console.Write("Invalid input, enter Building Number again: ");
            //            }

            //            DeliveryAddress address = new DeliveryAddress(city1, street1, buildingNum1);
            //            Shipment shipment = new Shipment(trackingCode1, description1, weight1, fee1, address);

            //            bool added1 = center.AddShipment(shipment);
            //            Console.WriteLine(added1 ? "Shipment added successfully.\n" : "Delivery center is full.\n");

            //            //express shipment

            //            Console.WriteLine($"--- Enter Shipment 2  Data  Express Shipment---");
            //            Console.Write("TrackingCode: ");
            //            string trackingCode2 = Console.ReadLine();

            //            Console.Write("Description: ");
            //            string description2 = Console.ReadLine();

            //            Console.Write("Weight: ");
            //            decimal weight2;
            //            while (!decimal.TryParse(Console.ReadLine(), out weight2))
            //            {
            //                Console.Write("Invalid input, enter Weight again: ");
            //            }

            //            Console.Write("DeliveryFee: ");
            //            decimal fee2;
            //            while (!decimal.TryParse(Console.ReadLine(), out fee2))
            //            {
            //                Console.Write("Invalid input, enter DeliveryFee again: ");
            //            }

            //            Console.Write("City: ");
            //            string city2 = Console.ReadLine();

            //            Console.Write("Street: ");
            //            string street2 = Console.ReadLine();

            //            Console.Write("Building Number: ");
            //            int buildingNum2;
            //            while (!int.TryParse(Console.ReadLine(), out buildingNum2))
            //            {
            //                Console.Write("Invalid input, enter Building Number again: ");
            //            }

            //            Console.Write("Extra Fee: ");
            //            decimal extraFee;
            //            while (!decimal.TryParse(Console.ReadLine(), out extraFee))
            //            {
            //                Console.Write("Invalid input, enter Extra Fee again: ");
            //            }

            //            DeliveryAddress address2 = new DeliveryAddress(city2, street2, buildingNum2);
            //            ExpressShipment shipment2 = new ExpressShipment(trackingCode2, description2, weight2, fee2, address2, extraFee);

            //            bool added2 = center.AddShipment(shipment2);
            //            Console.WriteLine(added2 ? "Shipment added successfully.\n" : "Delivery center is full.\n");


            //            //international shipment
            //            Console.WriteLine($"--- Enter Shipment 3  Data  International Shipment---");
            //            Console.Write("TrackingCode: ");
            //            string trackingCode3 = Console.ReadLine();

            //            Console.Write("Description: ");
            //            string description3 = Console.ReadLine();

            //            Console.Write("Weight: ");
            //            decimal weight3;
            //            while (!decimal.TryParse(Console.ReadLine(), out weight2))
            //            {
            //                Console.Write("Invalid input, enter Weight again: ");
            //            }

            //            Console.Write("DeliveryFee: ");
            //            decimal fee3;
            //            while (!decimal.TryParse(Console.ReadLine(), out fee2))
            //            {
            //                Console.Write("Invalid input, enter DeliveryFee again: ");
            //            }

            //            Console.Write("City: ");
            //            string city3 = Console.ReadLine();

            //            Console.Write("Street: ");
            //            string street3 = Console.ReadLine();

            //            Console.Write("Building Number: ");
            //            int buildingNum3;
            //            while (!int.TryParse(Console.ReadLine(), out buildingNum2))
            //            {
            //                Console.Write("Invalid input, enter Building Number again: ");
            //            }

            //            Console.Write("Extra Fee: ");
            //            decimal extraFee3;
            //            while (!decimal.TryParse(Console.ReadLine(), out extraFee))
            //            {
            //                Console.Write("Invalid input, enter Extra Fee again: ");
            //            }

            //            DeliveryAddress address3 = new DeliveryAddress(city2, street2, buildingNum2);
            //            ExpressShipment shipment3 = new ExpressShipment(trackingCode2, description2, weight2, fee2, address2, extraFee);

            //            bool added3 = center.AddShipment(shipment2);
            //            Console.WriteLine(added2 ? "Shipment added successfully.\n" : "Delivery center is full.\n");


            //            //all shipments
            //            Console.WriteLine("--- All Shipments ---");
            //            center.PrintAllShipments();

            //            Console.WriteLine("\n--- All Shipments (Indexer Test ---");
            //            for (int i = 0; i < 3; i++)
            //            {
            //                Shipment s = center[i];
            //                if (s != null)
            //                {
            //                    s.PrintShipment();
            //                    Console.WriteLine();
            //                }
            //            }

            //            //search by code

            //            Console.Write("Enter a tracking code to search: ");
            //            string search = Console.ReadLine();
            //            Shipment found = center[search];

            //            if (found != null)
            //                Console.WriteLine($"Shipment found: {found.Trackingcode} - {found.description}");
            //            else
            //                Console.WriteLine("Shipment not found.");

            //            //remove tracking code
            //            Console.Write("Enter Tracking Code to Remove: ");
            //            string codeToRemove = Console.ReadLine();

            //            if (center.RemoveShipment(codeToRemove))
            //            {
            //                Console.WriteLine("\nShipment Removed Successfully.\n");
            //            }
            //            else
            //            {
            //                Console.WriteLine("\nShipment Not Found.\n");
            //            }

            //            Console.WriteLine("==============================================");
            //            Console.WriteLine("Remaining Shipments");
            //            Console.WriteLine("==============================================");
            //            center.PrintAllShipments();

            //            //struct copy test
            //            Console.WriteLine("\n--- Struct Copy Test ---");
            //            DeliveryAddress originalAddress = new DeliveryAddress("Cairo", "Tahrir Street", 15);
            //            DeliveryAddress copiedAddress = originalAddress;

            //            copiedAddress = new DeliveryAddress("Cairo", "Makram Ebeid Street", 20);

            //            Console.WriteLine("Original Address: " + originalAddress.GetFullAddress());
            //            Console.WriteLine("Copied Address: " + copiedAddress.GetFullAddress());


            //            //DeliveryAddress deliveryAddress = new DeliveryAddress("cairo","mohamed salim",26);
            //            //DeliveryAddress deliveryAddress2 = deliveryAddress;
            //            ////before modification
            //            //Console.WriteLine(deliveryAddress2);
            //            //deliveryAddress.city = "giza";
            //            ////after modification , (didn't change) 
            //            //Console.WriteLi
        }
    }
    }
