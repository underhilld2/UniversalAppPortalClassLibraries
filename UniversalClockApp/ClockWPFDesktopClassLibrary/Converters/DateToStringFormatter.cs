using System;



namespace XamlHelpers.Converters
{
   public sealed class DateToStringFormatter : IValueConverter
   {
      public object Convert( object value, Type targetType, object parameter, string language )
      {
         return DateToStringCommonCode.Convert( value, targetType, parameter, language );
      }

      public object ConvertBack( object value, Type targetType, object parameter, string language )
      {
         throw new NotImplementedException();
      }
   }


}
