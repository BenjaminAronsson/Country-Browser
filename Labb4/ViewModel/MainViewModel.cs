using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace Labb4
{
    public class MainViewModel : SimpleViewModel
    {
        public ICommand NextCountry { get; set; }
        public ICommand PreviusCountry { get; set; }
        CountryRepository repository;
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

        //public Country SelectedCountry
        //{
        //    get
        //    {
        //        return selectedCountry;
        //    }
        //    set
        //    {
        //        SetPropertyValue(ref selectedCountry, value);
        //    }
        //}


        public MainViewModel()
        {
            Index = 0;
            repository = new CountryRepository();

            countries = repository.Countries;

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
