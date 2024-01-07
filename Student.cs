public class Student: User{
    string password=string.Empty;
    public string Password{
        get{
            return this.password;
        }
        set{
            this.password=value;
        }
    }
}