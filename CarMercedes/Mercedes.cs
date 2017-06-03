using System;
using System.ComponentModel.Composition;

namespace CarMercedes
{
    [Export(typeof(CarHost.ICarContract))]
    public class Mercedes : CarHost.ICarContract
    {
        public string StartEngine(string name)
        {           
            return String.Format("{0} starts the Mercedes.", name);
        }
    }
}
