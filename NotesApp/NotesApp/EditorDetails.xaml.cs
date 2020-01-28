using Plugin.Share;
using Plugin.Share.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NotesApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditorDetails : ContentPage
    {
        public EditorDetails()
        {
            InitializeComponent();
            
            
        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            var detailsInfo = (InformationDetails)BindingContext;
            detailsInfo.Name = NameEditor.Text;
            detailsInfo.Details = DetailsEditor.Text;

            Navigation.PopAsync();
        }

        

        
        
    }
}