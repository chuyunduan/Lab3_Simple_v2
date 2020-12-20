using System;

namespace Lab3_Simple_v2
{


    class Program
    {
        private static void DataChangedHandler(object source, DataChangedEventArgs args)
        {
            Console.WriteLine(args.ToString());
        }

        static void Main(string[] args)
        {
            try
            {
                //1
                V2MainCollection mainCollection = new V2MainCollection();
                mainCollection.DataChanged += DataChangedHandler;

                //2
                mainCollection.AddDefaults();

                V2DataCollection re = new V2DataCollection("Replace", 0);
                mainCollection[0] = re;

                mainCollection[1].Info = "Change";
                mainCollection[1].Freq = 50;

                mainCollection.Remove("Change",1);

                Console.WriteLine(mainCollection.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}