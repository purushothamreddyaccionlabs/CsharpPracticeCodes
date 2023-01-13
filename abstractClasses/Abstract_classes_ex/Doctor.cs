using Abstract_classes_ex;

public class Doctor:Person
{
    //fields
    public string degree;
    public string degignation;


    //constructor
    public Doctor(string name, int age,string lastName, string gender, string address,string degree,string degignation):base( name, age, gender,address,lastName)
    {
        this.degree = degree;
        this.degignation = degignation;
    }

    //set and get
    public string Degree
    {
        get { return degree; }
        set { degree = value; }
    }

    // set and get
    public string Degignation
    {
        get { return degignation;}
        set { degignation = value; }
    }


}