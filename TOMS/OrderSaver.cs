using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace TOMS
{
    class OrderSaver
    {
        private string OrderSavePath;

        public OrderSaver(string path)
        {
            Uri tempUri = new Uri(path);
            if (tempUri.IsWellFormedOriginalString())
            {
                OrderSavePath = path;
            }
            /*else
                throw InvalidDataException; */
        }

        public void WriteToFile(Order orderObj)
        {
            FileStream OFile = new FileStream(this.OrderSavePath, FileMode.Append);
            StreamWriter sw = new StreamWriter(OFile);
            orderObj.updateTimeStamp();
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(orderObj);
            sw.WriteLine(json);
            sw.Close();
        }
    }
}
