using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contacts;
using Contacts.Classes;
using SQLite;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Contacts {
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class ContactsPage : ContentPage {
    public ContactsPage() {
      InitializeComponent();
    }

    private void NewContactToolbarItem_Clicked(object sender, EventArgs e) {
      Console.WriteLine("new pressed");
      Navigation.PushAsync(new MainPage());
    }
    protected override void OnAppearing() {
      base.OnAppearing();

      using ( SQLiteConnection conn = new SQLiteConnection(App.FilePath) ) {
        conn.CreateTable<Contact>();
        var contacts = conn.Table<Contact>().ToList();
        List<string> contactsName = new List<string>();

        contactsListView.ItemsSource = contacts;

        //foreach ( Contact contact in contacts ) {
        //  contactsName.Add(contact.Name);
        //}

        //contactsListView.ItemsSource = contactsName;
      }
    }

    private void DeleteButton_Clicked(System.Object sender, System.EventArgs e, int Id) {
      using ( SQLiteConnection conn = new SQLiteConnection(App.FilePath) ) {
        conn.CreateTable<Contact>();
        conn.Delete<Contact>(Id);
      }
    }
  }
}