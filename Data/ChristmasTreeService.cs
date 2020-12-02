using System;
using System.Linq;
using System.Threading.Tasks;
using System.Device.Spi;
using System.Collections.Generic;

namespace xmasblazor.Data
{
    public class ChristmasTreeService
    {
        public void TurnOn()
        {
            SpiConnectionSettings settings = new SpiConnectionSettings(0);
            settings.Mode = SpiMode.Mode3;

            SpiDevice device = SpiDevice.Create(settings);

            List<byte> data = new List<byte>();
            data.AddRange(new byte[] { 0, 0, 0, 0 }); // start frame
            for (int i = 0; i < 25; i++)
            {
                data.AddRange(new byte[] { 1, 1, 1, 1 });
            }
            data.AddRange(new byte[] { 0, 0, 0, 0, 0 });

            device.Write(data.ToArray());
        }
    }
}
