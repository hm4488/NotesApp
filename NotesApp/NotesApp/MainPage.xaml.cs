
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

//Name:- Harsh Mathur
//Homework:- Homework 1 - NotesApp
//Course:- Mobile Application Development
//Date:- 1/18/2020
//Professor:- Brian Trager
namespace NotesApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public IList<InformationDetails> InformationDetails { get; private set; }

        

        public MainPage()
        {
            InitializeComponent();

            InformationDetails = new List<InformationDetails>();

            InformationDetails.Add(new InformationDetails
            {
                Name = "Playing Football",
                
                Details = "To play as Outside Linebacker"
            });

            InformationDetails.Add(new InformationDetails
            {
                Name = "Complete Mobile App Homework",
                
                Details = "To complete the Mobile App homework that is due on next week"
            });

            InformationDetails.Add(new InformationDetails
            {
                Name = "Complete Resume",
                
                Details = "To complete the resume as internship is coming up soon"
            });

            InformationDetails.Add(new InformationDetails
            {
                Name = "Do chores",
               
                Details = "To catch up the remaining chores or roommate will complain"
            });

            InformationDetails.Add(new InformationDetails
            {
                Name = "Meet the academic advisor",
                
                Details = "To meet the academic advisor to add courses for next semester"
            });

            InformationDetails.Add(new InformationDetails
            {
                Name = "Study for Azure certification",
               
                Details = "To prepare for upcoming Azure examination"
            });

            BindingContext = this;
            InformationDetailsListView.ItemSelected += SelectedListViewItem;

        }

        private async void SelectedListViewItem(object sender, SelectedItemChangedEventArgs e)
        {

            await Navigation.PushAsync(new EditorDetails
            {
                BindingContext = e.SelectedItem as InformationDetails
            }) ;




        }


        private void ThemePicker_Clicked(object sender, EventArgs e)
        {
            ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
            if (mergedDictionaries != null)
            {
                mergedDictionaries.Clear();

                if (this.BackgroundColor == Color.White)
                {
                    mergedDictionaries.Add(new DarkTheme());
                }
                else
                {
                    mergedDictionaries.Add(new LightTheme());
                }
            }
        }
    }
}
