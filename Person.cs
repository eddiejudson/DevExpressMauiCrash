using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiCrash
{
    public  partial class Person : ObservableObject
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                SetProperty(ref this.name, value);
            }
        }

        private DateTime birthDate;
        public DateTime BirthDate
        {
            get { return birthDate; }
            set
            {
                SetProperty(ref this.birthDate, value);
            }
        }

       
    }
}
