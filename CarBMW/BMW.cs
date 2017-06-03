using System;
using System.ComponentModel.Composition;

namespace CarBMW
{
    [Export(typeof(CarHost.ICarContract))]
    public class BMW : CarHost.ICarContract
    {
        public string StartEngine(string name)
        {
            return String.Format("{0} starts the BMW.", name);
        }
    }
}
