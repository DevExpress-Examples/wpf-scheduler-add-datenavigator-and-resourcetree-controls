using DevExpress.Xpf.Scheduling;
using System;
using System.Windows;

namespace SchedulerDateNavigatorExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DevExpress.Xpf.Core.ThemedWindow
    {
        public MainWindow() {
            InitializeComponent();
        }

        #region #CustomizeSpecialDates
        private void SchedulerDateNavigatorStyleSettings_CustomizeSpecialDates(object sender, CustomizeSpecialDatesEventArgs e)
        {
            e.SpecialDates.Add(DateTime.Today.AddDays(-2));
            e.SpecialDates.Add(DateTime.Today.AddDays(-4));
            e.SpecialDates.Add(DateTime.Today.AddDays(2));
        }
        #endregion #CustomizeSpecialDates
    }
}
