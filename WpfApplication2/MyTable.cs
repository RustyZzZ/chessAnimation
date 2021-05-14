using System.Collections.Generic;
using System.Windows.Controls;

namespace WpfApplication2
{
    public class MyTable : Grid
    {
        public List<Button> Buttons = new List<Button>();

        public Button this[int i, int j]
        {
            get { return Buttons[i * 3 + j - 1]; }
        }
    }
}