using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Contacts {
  public partial class App : Application {

    public static string FilePath;
    //public App()
    //{
    //  InitializeComponent();

    //  MainPage = new NavigationPage(new ContactsPage()); //This is the first page that appears

    //}

    public App(string path)
    {
      InitializeComponent();

      MainPage = new NavigationPage(new ContactsPage()); //This is the first page that appears

      FilePath = path;
    }

    protected override void OnStart()
    {
    }

    protected override void OnSleep()
    {
    }

    protected override void OnResume()
    {
    }
  }
}
