using Chiwchi.Console;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = Colorful.Console;


namespace console_bootstrap
{
    public static class Extensions
    {

        #region String
        public static string pascal(this string str)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str);
        }

        #endregion

        #region Text Output
        public static void write(this string str, Color color)
        {
            Console.WriteLine(str, color);
        }

        public static void write(this string str)
        {
            Console.WriteLine(str, Color.White);
        }

        public static string ask(this string str)
        {
            Console.WriteLine(str, Color.Yellow);
            return Console.ReadLine();
        }

        public static void log(this string str)
        {
            Console.WriteLine(str, Color.AliceBlue);
        }

        public static void success(this string str)
        {
            Console.WriteLine(str, Color.Green);
        }

        public static void exception(this string str)
        {
            throw new Exception(str);
        }

        public static void error(this string str)
        {
            Console.WriteLine(str, Color.Red);
        }

        public static void error(this Exception exp)
        {
            exp.ToString().error();
        }
        #endregion


        #region Others

        public static async void spin(this Func<Task> action)
        {
            ConsoleSpinner spinner = new ConsoleSpinner();
            spinner.Start();
            await action();
            spinner.Stop();
        }


        #endregion


        #region Json
        public static JToken get(this JToken token, string property)
        {
            return token.SelectToken(property);
        }

        #endregion
    }
}
