﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace Group1Project
{
//Interface Service: định nghĩa các hàm cung cấp cho client
    [ServiceContract(Namespace = "http://myuri.org/Simple")]
    public interface IService
    {
        [OperationContract]
        string GetAuthors();


    }//
    // cái này hiện tại đừng làm sớm, sau này hãy làm
    //[DataContract]
    //public class Member
    //{
    //    private string code;
    //    private string fullname;
    //    private string _class;

    //    [DataMember]
    //    public string Code
    //    {
    //        get{return code;}
    //        set{code = value;}
    //    }
    //    [DataMember]
    //    public string FullName
    //    {
    //        get{return fullname;}
    //        set{fullname = value;}
    //    }
    //    [DataMember]
    //    public string _Class
    //    {
    //        get{return _class;}
    //        set{_class = value;}
    //    }

    //    public Member(string _code, string _fullname, string __class)
    //    {
    //        this.code = _code;
    //        this.fullname = _fullname;
    //        this._Class = __class;
    //    }
    //}
}
