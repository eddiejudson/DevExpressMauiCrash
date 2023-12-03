namespace MauiCrash
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage(PeopleModel peopleModel)
        {
            InitializeComponent();
            BindingContext = peopleModel;
        }

        private void dxExCollectionView_Tap(object sender, DevExpress.Maui.CollectionView.CollectionViewGestureEventArgs e)
        {
            Navigation.PushAsync(new EditPerson((Person)e.Item), true);
        }
    }

}
