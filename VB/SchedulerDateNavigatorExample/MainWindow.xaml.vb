Imports DevExpress.Xpf.Scheduling

Namespace SchedulerDateNavigatorExample

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits DevExpress.Xpf.Core.ThemedWindow

        Public Sub New()
            Me.InitializeComponent()
        End Sub

#Region "#CustomizeSpecialDates"
        Private Sub SchedulerDateNavigatorStyleSettings_CustomizeSpecialDates(ByVal sender As Object, ByVal e As CustomizeSpecialDatesEventArgs)
            e.SpecialDates.Add(Date.Today.AddDays(-2))
            e.SpecialDates.Add(Date.Today.AddDays(-4))
            e.SpecialDates.Add(Date.Today.AddDays(2))
        End Sub
#End Region  ' #CustomizeSpecialDates
    End Class
End Namespace
