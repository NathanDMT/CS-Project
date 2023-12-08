using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Image = System.Drawing.Image;

namespace CS_Project.Service
{
    public static class ResourceService
    {
        private static readonly string ProductsImagePath = Application.StartupPath + "/products";

        public static Image GetProductImage(string name)
        {
            return Image.FromFile(string.Join("/", ProductsImagePath, name));
        }
    }
}
