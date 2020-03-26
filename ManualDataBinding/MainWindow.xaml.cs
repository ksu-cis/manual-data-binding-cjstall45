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
using ManualDataBinding.Data;

namespace ManualDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// new note initilizer 
        /// </summary>
        Note note = new Note();
        public MainWindow()
        {
            InitializeComponent();
            Editor.Note = note;
        }
        /// <summary>
        /// event handler to create new note
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnNewNote(object sender, RoutedEventArgs e)
        {
            note = new Note();
            Editor.Note = note;
        }
        /// <summary>
        /// event handler to clear a note
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnClearNote(object sender, RoutedEventArgs e)
        {
            note.Body = "";
        }

        public void OnMutateNote(object sender, RoutedEventArgs e)
        {
            note.Title = "Karl Marx";
            note.Body = "The last capitalist we hang shall be the one who sold us the rope.";
        }
    }
}
