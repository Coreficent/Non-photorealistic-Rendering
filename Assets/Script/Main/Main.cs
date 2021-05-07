namespace Coreficent.Main
{
    using Coreficent.Utility;
    using System.Collections.Generic;

    public class Main : Script
    {
        private Main()
        {
            List<string> list = new List<string>();
            list.Add("tt");
            list.Add("dd");

            Test.Warn("test list", list, new List<string>(), "");
        }
    }
}
