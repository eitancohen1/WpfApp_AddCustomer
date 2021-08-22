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

namespace Wpfmatirial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //בדיקת תאים ריקים
            if (FirstName.Text != "" && LastName.Text != "" && (Id.Text != "") && PhoneNum.Text != "" && Birthday.Text != "")
            {
                //הודעה על הצלחת הפעולה להוספה
                MessageBox.Show(
                   "Full Name:\t" + FirstName.Text + " " + LastName.Text + "\r\n\r" +
                   "Id:\t\t" + Id.Text + "\r\n\r" +
                   "Phone Number:\t" + PhoneNum.Text + "\r\n\r" +
                   "Date of Birth:\t" + Birthday.Text, " !!נוסף בהצלחה"
                   );

                //ניקוי התאים בסיום הפעולה
                Id.Clear();
                FirstName.Clear();
                LastName.Clear();
                PhoneNum.Clear();
                Birthday.SelectedDate = null;

                this.Close();
            }
            else
                MessageBox.Show("!חובה למלא את כל השדות");

        }
    }
}
