using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Collection
{
    class Movie
    {
        public string Title { get; set; }
        public int Date { get; set; }
        public string Runtime { get; set; }

        public Movie(string title1, int date1, string rt)
        {
            Title = title1;
            Date = date1;
            ConvertRuntime(rt);
        }
        
        private void ConvertRuntime(string time)
        {
            string[] rt;
            int HrRuntime, MinRuntime;

            if(time.Contains(":"))
            {
                rt = time.ToString().Split(':');

                HrRuntime = Convert.ToInt32(rt[0]);
                MinRuntime = Convert.ToInt32(rt[1]);

                if (HrRuntime == 0)
                    Runtime = String.Format("{0} Minutes", MinRuntime);
                else
                    Runtime = String.Format("{0} Hour {1} Minutes", HrRuntime, MinRuntime);
            }
            else
                Runtime = time;
        }
    }
}
