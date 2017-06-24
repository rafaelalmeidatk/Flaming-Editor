using Caliburn.Micro;
using System;
using System.ComponentModel;
using System.Linq.Expressions;

namespace Flaming_Editor.Project
{
    public class PropertyChangedBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyOfPropertyChange<TProperty>(Expression<Func<TProperty>> property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property.GetMemberInfo().Name));
        }
    }
}
