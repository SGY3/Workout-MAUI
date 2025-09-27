using Workout.MVVM.ViewModels;

namespace Workout.MVVM.Views;

public partial class ExercisePage : ContentPage
{
    public ExercisePage()
    {
        InitializeComponent();
        BindingContext = new MainPageViewModel();
    }
}