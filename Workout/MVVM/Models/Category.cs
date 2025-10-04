using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int PendingExercises { get; set; }
        public double Percentage { get; set; }
        public bool IsSelected { get; set; }
    }
}
