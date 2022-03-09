using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using daycare22.Models;


namespace daycare22.Data
{
    interface IClasses
    {

        public List<Classes> List();

        public Classes GetClassesById(int id);

        public Classes AddClasses(Classes classes);
    }
}
