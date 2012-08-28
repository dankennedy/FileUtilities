using System;
using System.Windows.Forms;

namespace FileUtilities
{
    public static class FormsExtensionMethods
    {
         public static void InvokeIfRequired<T>(this T c, Action<T> action) where T : Control
         {
             if (c.InvokeRequired)
                 c.Invoke(new Action(() => action(c)));
             else
                 action(c);
         }

        public static string ToShortDateTimeString(this DateTime dateTime)
        {
            return dateTime.ToShortDateString() + " " + dateTime.ToShortTimeString();
        }
    }
}