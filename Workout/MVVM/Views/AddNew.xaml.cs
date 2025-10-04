using Workout.MVVM.Models;
using Workout.MVVM.ViewModels;

namespace Workout.MVVM.Views;

public partial class AddNew : ContentPage
{
    public AddNew()
    {
        InitializeComponent();
    }

    private void AddExercise_Clicked(object sender, EventArgs e)
    {
        var viewModel = BindingContext as AddNewViewModel;
        var selectedCategory = viewModel.Categories.Where(x => x.IsSelected == true).FirstOrDefault();
        if (selectedCategory != null)
        {
            var exercise = new Exercise
            {
                Name = viewModel.Exercise,
                CategoryId = selectedCategory.Id
            };
            viewModel.Exercises.Add(exercise);
            Navigation.PopAsync();
        }
        else
        {
            DisplayAlert("Category not select", "Select aleast one category", "OK");
        }
    }

    private async void AddCategory_Clicked(object sender, EventArgs e)
    {
        var categoryTitle = await DisplayPromptAsync("Add new category", "Enter category name", maxLength: 100, keyboard: Keyboard.Text);
        var viewModel = BindingContext as AddNewViewModel;
        viewModel.Categories.Add(new Category
        {
            Id = viewModel.Categories.Max(x => x.Id) + 1,
            Title = categoryTitle
        });
    }
}