using App3;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>


    public sealed partial class MainPage : Page
    {
        private ObservableCollection<String> ToDoList;
        


        public MainPage()
        {
            this.InitializeComponent();
            ToDoList = new ObservableCollection<String>();
            ToDoList.Add("This is a todo");
        }
        
    
         private void OnPreviewKeyDownHandler(object sender, KeyRoutedEventArgs e)
         {
            if (e.Key == Windows.System.VirtualKey.Enter)
             {
                
                ToDoList.Add(textBox.Text);
                 textBox.Text = "";
             }

        }
          private void OnDoubleTap(Object sender, DoubleTappedRoutedEventArgs e)
          {
              ToDoList.RemoveAt(MyListView.SelectedIndex);

        }
        private void OnTextboxTap(Object sender ,TappedRoutedEventArgs e)
        {
            textBox.Focus(FocusState.Programmatic);
        }

    }


    public class ToDo //to do migrate from strings to todo
    { private string todotext;
        public ToDo(string todoinput)
        {
            this.todotext = todoinput;
        }
        public string ToDoText {
            get { return todotext; }
            set { todotext = value;}


        }





    }
    public class DataList : ObservableCollection<ToDo>
    {
        public DataList() : base()
        {
           

        }

    } 
}

