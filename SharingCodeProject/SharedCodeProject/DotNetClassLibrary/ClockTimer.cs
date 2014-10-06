using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetClassLibrary
{
   public class ClockTimer1 : PropertyChangeLogic
   {
      //private DispatcherTimer _dispatcherTimer;

      //public ClockTimer()
      //{
      //   _dispatcherTimer = new DispatcherTimer();
      //   _dispatcherTimer.Tick += dispatcherTimer_Tick;
      //   _dispatcherTimer.Interval = new TimeSpan( 0, 0, 1 );
      //   _dispatcherTimer.Start();
      //}


      public void dispatcherTimer_Tick( object sender, object e )
      {
         NotifyPropertyChanged( "CurrentDateTime" );
      }

      public DateTime CurrentDateTime
      {
         get
         {
            return DateTime.Now;
         }
      }




   }
}
