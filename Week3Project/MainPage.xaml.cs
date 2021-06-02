using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Week3Project
{
    public partial class MainPage : ContentPage
    {
        Manager manager;
        public MainPage(Manager m)
        {
            InitializeComponent();// UI 
            manager = m;
            studentList.ItemsSource = m.students;
        }

        void CallStudentEvent(System.Object sender, System.EventArgs e)
        {
            
            //DisplayAlert("Calling ...", (sender as Student).name, "OK");
        }

        void studentList_ItemSelected(System.Object sender,
            Xamarin.Forms.SelectedItemChangedEventArgs e)
        {

            DisplayAlert("Selecting ...", (e.SelectedItem as Student).name, "OK");
        }

        void call_Clicked(System.Object sender, System.EventArgs e)
        {
            var menu = (sender as MenuItem);
            var std = menu.CommandParameter as Student;
            DisplayAlert("Calling ...", std.name, "OK");

        }

        void Delete_Clicked(System.Object sender, System.EventArgs e)
        {
            var std = (sender as MenuItem).CommandParameter as Student;
            manager.deleteStd(std);

        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            //if (name_text.Text)
            var newStd = new Student(name_text.Text.ToString(), Convert.ToInt32(id_text.Text), Convert.ToInt32(age_text.Text));
            manager.addStd(newStd);

        }

       async void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
           await Navigation.PushModalAsync(new AddNewCoursePage(manager));
        }
    }
}
