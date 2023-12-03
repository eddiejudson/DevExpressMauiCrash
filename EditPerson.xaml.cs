namespace MauiCrash;

public partial class EditPerson : ContentPage
{
	public EditPerson(Person binding)
	{
		InitializeComponent();
		BindingContext = binding;
	}
}