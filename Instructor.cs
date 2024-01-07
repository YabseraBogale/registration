public class Instructor:User{
    string password=string.Empty;
    int creadithour=new Courese().CreaditHour;
    public string Password{
        get{
            return this.password;
        }
        set{
            this.password=value;
        }
    }
    public int CreaditHour{get{
        return this.creadithour;
    }
    }
}