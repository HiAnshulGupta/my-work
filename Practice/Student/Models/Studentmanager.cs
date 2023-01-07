using System.Collections.Generic;
using Stud.Model;
namespace SManager.Model;

public class StudentManager{


    public static List<Student2>GetAllStudent(){
        List<Student2> allstud=new List<Student2>();


        allstud.Add(new Student2(1,"Anshul","Java",10000));
        allstud.Add(new Student2(1,"sahil","Java",11000));
        allstud.Add(new Student2(1,"Anshul","Java",10000));
        

    return allstud;

    }
}

