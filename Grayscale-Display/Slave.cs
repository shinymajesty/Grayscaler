using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grayscale_Display
{
    public class Slave
    {
        FileDAO fileDAO = new FileDAO();

        public void Start(string filepath)
        {
            var x = fileDAO.LoadImage(filepath);

        }
    }
}
