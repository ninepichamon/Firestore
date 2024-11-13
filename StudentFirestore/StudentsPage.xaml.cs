using StudentFirestore.Services;
using StudentFirestore.ViewModels;
namespace StudentFirestore;

public partial class StudentsPage : ContentPage
{
	public StudentsPage()
	{
		InitializeComponent();
		var firestoreService = new FirestoreService();
		BindingContext = new StudentsViewModel(firestoreService);
	}
}