using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Common
    {

        public interface IService
        {
            void GetStuff(Action<List<string>> action);

            void GetMoreStuff(Action<List<string>> action);
        }


        public abstract class ViewModelProviderBase<T> : INotifyPropertyChanged where T : class
        {
            public static Func<T> Resolve { get; set; }

            public ViewModelProviderBase()
            {
                T viewModel = Resolve();
                if (viewModel != null)
                {
                    _viewModel = viewModel;
                }
            }

            private T _viewModel;

            public T ViewModel
            {
                get { return _viewModel; }
                set
                {
                    _viewModel = value;
                    OnPropertyChanged("ViewModel");
                }
            }

            protected void OnPropertyChanged(string propertyName)
            {
                PropertyChangedEventHandler handler = PropertyChanged;
                if (handler != null)
                {
                    handler(this, new PropertyChangedEventArgs(propertyName));
                }
            }

            #region INotifyPropertyChanged Members

            public event PropertyChangedEventHandler PropertyChanged;

            #endregion
        }

    }
}
