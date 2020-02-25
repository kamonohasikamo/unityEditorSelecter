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
using System.Collections.ObjectModel;

public class PrefList
{
    public ObservableCollection<string> Data { get; }
    public PrefList()
    {
        Data = new ObservableCollection<string>();
        Data.Add("北海道");
        Data.Add("青森県");
        Data.Add("岩手県");
        Data.Add("秋田県");
    }
}

namespace UnityEditorSelecter
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new PrefList();
        }
    }
}