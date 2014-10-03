using System;
using Windows.UI.Xaml.Data;


namespace XamlHelpers.Converters
{
   public sealed class DateToStringFormatter : IValueConverter
   {
      public object Convert( object value, Type targetType, object parameter, string language )
      {
         return PortableClassLibraryForDotNet40.Converters.DateToStringFormatter.Convert(value, targetType, parameter, language);
      }

      public object ConvertBack( object value, Type targetType, object parameter, string language )
      {
         throw new NotImplementedException();
      }
   }


}
