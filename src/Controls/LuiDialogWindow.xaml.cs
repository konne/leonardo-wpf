﻿using leonardo.Resources;
using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace leonardo.Controls
{
    /// <summary>
    /// Interaktionslogik für LuiDialogWindow.xaml
    /// </summary>
    public partial class LuiDialogWindow : Window, INotifyPropertyChanged
    {
        #region LoggerInit
        private static Logger logger = LogManager.GetCurrentClassLogger();
        #endregion

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged([CallerMemberName] string caller = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(caller));
        }
        #endregion

        #region ctor
        public LuiDialogWindow()
        {
            InitializeComponent();
            DataContext = this;
        }
        #endregion

        #region Poperties
        private string headerText;
        public string HeaderText
        {
            get { return headerText; }
            set
            {
                if (headerText != value)
                {
                    headerText = value;
                    RaisePropertyChanged();
                }
            }
        }

        private object child;
        public object Child
        {
            get { return child; }
            set
            {
                if (child != value)
                {
                    child = value;
                    RaisePropertyChanged();
                }
            }
        }
        private bool showOK = true;
        public bool ShowOK
        {
            get { return showOK; }
            set
            {
                if (showOK != value)
                {
                    showOK = value;
                    RaisePropertyChanged();
                }
            }
        }
        private bool showCancel = true;
        public bool ShowCancel
        {
            get { return showCancel; }
            set
            {
                if (showCancel != value)
                {
                    showCancel = value;
                    RaisePropertyChanged();
                }
            }
        }
        private ICommand okCommand;
        public ICommand OkCommand
        {
            get { return okCommand; }
            set
            {
                if (okCommand != value)
                {
                    okCommand = value;
                    RaisePropertyChanged();
                }
            }
        }
        private ICommand cancelCommand;
        public ICommand CancelCommand
        {
            get { return cancelCommand; }
            set
            {
                if (cancelCommand != value)
                {
                    cancelCommand = value;
                    RaisePropertyChanged();
                }
            }
        }
        #endregion

        #region statics
        public static void Show(string headerText, int hwnd, object content, int width = 300, int height = 300, bool showOK = true, bool showCancel = true)
        {
            var wnd = new LuiDialogWindow()
            {
                WindowStyle = WindowStyle.None,
                HeaderText = headerText,
                Child = content,
                Height = height,
                Width = width,
                showCancel = showCancel,
                ShowOK = showOK,
                WindowStartupLocation = WindowStartupLocation.CenterOwner
            };

            new WindowInteropHelper(wnd).Owner = new IntPtr((int)hwnd);



            wnd.OkCommand = new RelayCommand((o) => { wnd.Close(); });
            wnd.CancelCommand = new RelayCommand((o) => { wnd.Close(); });
            wnd.Show();
        }
    }
    #endregion
}
