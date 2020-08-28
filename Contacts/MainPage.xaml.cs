using System;
using Xamarin.Forms;

namespace Contacts {
  public partial class MainPage : ContentPage {
    public MainPage()
    {
      InitializeComponent();
    }

    private void SaveButton_Pressed(object sender, EventArgs e)
    {
      Console.WriteLine("Save Button pressed");
      Console.WriteLine(NameEntry.Text);
    }

    private void NameEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
      BindingContext = this;

      Console.WriteLine(NameEntry.Text);
      string previewText = NameEntry.Text; //Trying to change the value of a label on the go
    }
  }
}
