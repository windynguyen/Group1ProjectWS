using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace Group1Project
{
    //định nghĩa các hàm xử lý tại đây, override các hàm định nghĩa bên IService: Interface Service

     [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class OperationService: IService
    {
         //củ public List<Member> GetAuthors(){
             public string GetAuthors(){
            //củ
             //Member mem1 = new Member("080873","Nguyễn Thanh Phong","PM081");
             //Member mem2 = new Member("080922","Nguyễn Đình Tín","PM081");
             //Member mem3 = new Member("080890","Đặng Minh Thành","PM081");
            //List<Member> lst_mem = new List<Member>();
            //lst_mem.Add(mem1);
            //lst_mem.Add(mem2);
            //lst_mem.Add(mem3);
                 return "Sơn, Hiệp ....";// củ lst_mem;
        }
    }
}
