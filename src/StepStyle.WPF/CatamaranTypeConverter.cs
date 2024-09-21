using Domain;
using System.Globalization;
using System.Windows.Data;

namespace StepStyle.WPF.Views
{
    public class CatamaranTypeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is List<CatamaranType> catamaranTypes)
            {
                var newList = new List<CatamaranType>(catamaranTypes);

                
                newList.Insert(0, (CatamaranType)(-1)); 
                return newList;
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
