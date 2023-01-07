namespace Stud.Model;

public class Student2{

    private int id;
    private string name;
    private string course;
    private double fees;


    public Student2(){
   
    }

    public Student2(int Id, string Name,string Course,double Fees){

        this.id=Id;
        this.name=Name;
        this.course=Course;
        this.fees=Fees;
    }

    public int ID{
        get{return id;}
        set{id=value;}
    }

    public String Name{
        get{return name;}
        set{name=value;}
    }

    public String Course{
        get{return course;}
        set{course=value;}
    }

    public double Fees{
        get{return fees;}
        set{fees=value;}
    }



    
}