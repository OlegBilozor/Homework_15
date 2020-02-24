using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Homework_15
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public BitmapImage Avatar { get; set; }
        public string Author { get; set; }
    }
}
