using daycare22.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace daycare22.Data
{
 interface ITeacher
    {

        public List<Teacher> List();

        public Teacher GetTeacherById(int id);

        public Teacher AddTeacher(Teacher teacher);

        public Teacher RemoveTeacher(Teacher teacher);

    }
}
