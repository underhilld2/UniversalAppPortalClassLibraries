﻿using System;
using DotNetClassLibrary;

namespace SilverlightClassLibrary 
{
   public class ClockTimer : PropertyChangeLogic
   {
      //private DispatcherTimer _dispatcherTimer;

      //public ClockTimer()
      //{
      //   this._dispatcherTimer = new DispatcherTimer();
      //   this._dispatcherTimer.Tick += dispatcherTimer_Tick;
      //   this._dispatcherTimer.Interval = new TimeSpan( 0, 0, 1 );
      //   this._dispatcherTimer.Start();
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
