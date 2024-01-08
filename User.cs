public abstract class User{
    //use of "?" in the string is to tell the c# that first,middle and last are empty if not declared  
    //class could be defined as follows if null should be allowed for the name
    protected string? FirstName{ get; set;}
    protected string? MiddleName {get;set;}
    protected string? LastName{get;set;}
    // no use of "?" in int type b/c of int can know ahead of time as 0
    protected int UserId{get;}
    protected int DateOfBirth{get{ return this.DateOfBirth;}set{
            this.DateOfBirth=DateTime.Now.Year-value;
    }}
    protected char Gender{get;set;}

}