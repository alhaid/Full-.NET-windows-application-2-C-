using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    abstract class EntertainData
    {
        public abstract string MusicOrMovie();

        public abstract string EntertainGenre();

        public virtual string EntertainName() { return "Alhaid-Shop"; }
    }
}
