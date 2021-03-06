using System.Windows;
using System.Windows.Controls;

namespace BililiveRecorder.WPF.Converters
{
    internal class NullValueTemplateSelector : DataTemplateSelector
    {
        public DataTemplate Normal { get; set; }
        public DataTemplate Null { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container) => item is null ? Null : Normal;
    }
}
