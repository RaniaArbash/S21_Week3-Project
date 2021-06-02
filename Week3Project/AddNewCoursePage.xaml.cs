using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Week3Project
{
    public partial class AddNewCoursePage : ContentPage
    {
        Manager manager;
        public AddNewCoursePage(Manager m)
        {
            InitializeComponent();
            manager = m;
            list.ItemsSource = m.students;
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
          await  Navigation.PopModalAsync();
        }
    }
}
