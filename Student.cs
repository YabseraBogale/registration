public class Student: User{
    string password;
    public string Password{
        get{
            return this.password;
        }
        set{
            this.password=value;
        }
    }
}