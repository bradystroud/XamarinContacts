using Contacts.Classes;
using System;
using Xamarin.Forms;
using SQLite;
using System.Diagnostics.Contracts;

namespace Contacts {
  public partial class MainPage : ContentPage {
    public MainPage()
    {
      InitializeComponent();
    }

    private void SaveButton_Pressed(object sender, EventArgs e)
    {
      Console.WriteLine("Save Button pressed");
      Contact contact = new Contact()
      {
        Name = nameEntry.Text,
        LastName = lastNameEntry.Text,
        Email = emailEntry.Text,
        PhoneNumber = phoneEntry.Text,
        Address = addressEntry.Text
      };
      using (SQLiteConnection conn = new SQLiteConnection(App.FilePath)) {
        conn.CreateTable<Contact>();
        int rowsAdded = conn.Insert(contact);
        if(rowsAdded == 0)
        {
          Console.WriteLine("Unsuccessful row addition");
        } else
        {
          Console.WriteLine("Success: " + rowsAdded.ToString());
        }
      }
    }
  }
}
