using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplicationTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var t = Test5();
            var c = t.Count(i=>i>0);
            var cc = t.Count;
            var ii = t[0];
            t[0] = 3;
            t.Add(4);
            
            foreach (var item in t)
            {
                

            }
        }

        IEnumerable<int> Test1()
        {
            var r = new List<int>();
            r.Add(2);
            return r;
        }
        IReadOnlyCollection<int> Test2()
        {
            var r = new List<int>();
            r.Add(2);
            return r;
        }
        IReadOnlyList<int> Test3()
        {
            var r = new List<int>();
            r.Add(2);
            return r;
        }
        ICollection<int> Test4()
        {
            var r = new List<int>();
            r.Add(2);
            return r;
        }
        IList<int> Test5()
        {
            var r = new List<int>();
            r.Add(2);
            return r;
        }
    }
}
