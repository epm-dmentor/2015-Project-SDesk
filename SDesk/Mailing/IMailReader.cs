using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mailing
{
  public  interface IMailReader
    {
        void Connect(MapConfig config);
        void Authentificate(MapConfig config);
        void DeleteMessage(uint uid);
        event NewMailDelagate NewMailArrived;
    }
}
