using Workout.MVVM.Views;

namespace Workout
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ExercisePage());
        }
    }
}
