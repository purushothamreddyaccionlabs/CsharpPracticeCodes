namespace Abstract_classes_ex
{
    public abstract class Person
    {
        // fields
        public string name;
        public string lastName;
        public int age;
        public string gender;
        public string address;

        //constructor
        public Person(string name,int age,string gender,string address,string lastName)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.address = address;
            this.lastName = lastName;
        }

        //set and get values
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Gender
        {
            get { return gender; }
            set
            {
                gender = value;
            }
        }
        public string Lastname
        {
            get { return lastName; }
            set
            {
                lastName = value;
            }
        }
        public string Address
        {
            get { return address; }
            set
            {
                address = value;
            }
        }

        //method
        public string fullname()
        {
            return Name + " " + Lastname;
        }

    }
}