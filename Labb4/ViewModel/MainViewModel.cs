using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Input;
using Ninject;
using Xamarin.Forms;

namespace Labb4
{
    public class MainViewModel : SimpleViewModel
    {
        public ICommand NextCountry { get; set; }
        public ICommand PreviusCountry { get; set; }

        //ICountryRepository repository;
        List<Country> countries;

        Country selectedCountry;
        int index;
        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                SetPropertyValue(ref index, value);
            }
        }

        public event EventHandler CanExecuteChanged;

        public Country SelectedCountry
        {
            get
            {
                return selectedCountry;
            }
            set
            {
                SetPropertyValue(ref selectedCountry, value);
            }
        }

        
        public MainViewModel(ICountryRepository repository)
        {
            Index = 0;

            countries = repository.GetCountries();
            selectedCountry = countries[Index];

            NextCountry = new Command(
            execute: () =>
            {
                //Do something
                if (index >= countries.Count - 1)
                    return;

                Index++;
                SelectedCountry = countries[Index];
            },
            canExecute: () =>
            {
                return true;
            });

            PreviusCountry = new Command(
            execute: () =>
            {
                //Do something
                if (index <= 0)
                    return;

                Index--;
                SelectedCountry = countries[Index];
            },
            canExecute: () =>
            {
                return true;
            });
        }

    }
}
