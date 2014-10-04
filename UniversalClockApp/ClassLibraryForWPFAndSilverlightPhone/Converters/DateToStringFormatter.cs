using System;
using System.Globalization;
//using System.Windows.Data;

//using Windows.UI.Xaml.Data;


namespace ClassLibraryForSilverlight81.Converters
{
   public sealed class DateToStringFormatter //: IValueConverter
   {
      public object Convert( object value, Type targetType, object parameter, string language )
      {
         return PortableClassLibraryForDotNet40.Converters.DateToStringFormatter.Convert(value, targetType, parameter, language);
      }

      public object ConvertBack( object value, Type targetType, object parameter, string language )
      {
         throw new NotImplementedException();
      }

      public object Convert( object value, Type targetType, object parameter, CultureInfo culture )
      {
         return PortableClassLibraryForDotNet40.Converters.DateToStringFormatter.Convert( value, targetType, parameter, culture.ToString() );
      }

      public object ConvertBack( object value, Type targetType, object parameter, CultureInfo culture )
      {
         throw new NotImplementedException();
      }
   }


}
