using Microsoft.Practices.Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TestCommonUC.FormInputBox;

namespace TestCommonUC
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Type> windowTypeList { get; set; }
        public DelegateCommand<object> CallWinBtnCommand { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            CallWinBtnCommand = new DelegateCommand<object>(new Action<object>(HandleCallWin));
            windowTypeList = new List<Type>();
            windowTypeList.Add(typeof(FormInputBoxTestWindow));

            this.DataContext = this;
        }

        private void HandleCallWin(object obj)
        {
            Type type = obj as Type;
            Window win = (Window)type.Assembly.CreateInstance(type.FullName);
            win.ShowDialog();
        }
    }
}
