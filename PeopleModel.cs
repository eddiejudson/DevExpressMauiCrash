using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiCrash
{
    public class PeopleModel
    {
        public ObservableCollection<Person> People { get; set; } = new ObservableCollection<Person>();
        public PeopleModel() {
            People.Add(new Person { Name="Eddie",BirthDate=DateTime.Now.AddYears(-44)});
            People.Add(new Person { Name = "John", BirthDate = DateTime.Now.AddYears(-20) });
            People.Add(new Person { Name = "Michael", BirthDate = DateTime.Now.AddYears(-30) });
            People.Add(new Person { Name = "Steve"});

        }
    }
}
