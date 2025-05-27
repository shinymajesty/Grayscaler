using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grayscale_Display
{
    class FileDAO
    {
        public Image LoadImage(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Image file not found.", path);

            return Image.FromFile(path);
        }

        public byte[] LoadImageAsBytes(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Image file not found.", path);

            return File.ReadAllBytes(path);
        }
    }
}
