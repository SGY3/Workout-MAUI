using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workout.MVVM.Models;

namespace Workout.MVVM.ViewModels
{
    public class AddNewViewModel
    {
        public string Exercise { get; set; }
        public ObservableCollection<Exercise> Exercises { get; set; }
        public ObservableCollection<Category> Categories { get; set; }
    }
}
