using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicControl.Enitiles
{
    public class Students
    {
        public string Id { get; set; }
        public string FirtsName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string POB { get; set; }
        public EGender Gender { get; set; }
        public string HomeTown { get; set; }

        public string FullName
        {
            get
            {
                return $"{LastName} {FirtsName}";
            }
        }

        public static List<Students> GetList()
        {
            var ls = new List<Students>();
            ls.Add(new Students()
            {
                LastName = "Nguyễn",
                Id = "1",
                FirtsName = "Tâm",
                DOB = new DateTime(2000,11,17),
                POB = "Phú Vang",
                HomeTown = "Thừa Thiên Huế",
                Gender = EGender.Nam


            });

            ls.Add(new Students()
            {
                LastName = "Nguyễn",
                Id = "2",
                FirtsName = "Dũng",
                DOB = new DateTime(2000, 4, 17),
                POB = "Phú Vang",
                HomeTown = "Đà Nẵng",
                Gender = EGender.Nam


            });

            return ls;


        }

        public static Students Get(string id)
        {
            var dbStudent = GetList();

            var student = dbStudent.Where(s => s.Id == id).FirstOrDefault();
            return student;
        }





        

    }
    public enum EGender
    {
        Nam, Nu, Khac
    }
}
