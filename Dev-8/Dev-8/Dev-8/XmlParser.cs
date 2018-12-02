using System.Xml;
using System.Collections.Generic;
using System;

namespace Dev_5
{
    /// <summary>
    /// Read Xml document and creates 
    /// list of machines from document
    /// </summary>
    class XmlParser
    {
        /// <summary>
        /// Parses the xml document
        /// </summary>
        /// <returns>
        /// list of machines 
        /// </returns>
        /// <param name="filePath">
        /// File path
        /// </param>
        public List<IMachine> ParseXml(string filePath)
        {
            List<IMachine> machines = new List<IMachine>();
            MachineCreator machineCreator = MachineCreator.GetInstance();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(filePath);
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                string brand = string.Empty;
                string model = string.Empty;
                double price = 0.0;
                int quantity = 0;
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("Brand");
                    if (attr != null)
                        brand = attr.Value;
                }
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "model")
                    {
                        model = childnode.InnerText;
                    }
                    if (childnode.Name == "quantity")
                    {
                        int.TryParse(childnode.InnerText,out quantity);
                    }
                    if (childnode.Name == "price")
                    {
                        double.TryParse(childnode.InnerText,out price);
                    }
                }
                if (xnode.Name == "Car")
                {
                    machines.Add(machineCreator.CreateNewCar(brand, model, quantity, price));
                }
                else if (xnode.Name == "Truck")
                {
                    machines.Add(machineCreator.CreateNewTruck(brand, model, quantity, price));
                }else 
                {
                    throw new Exception("Invalid input data");
                }
            }
            return machines;
        }
    }
}