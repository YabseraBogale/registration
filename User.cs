public abstract class User{
    //use of "?" in the string is to tell the c# that first,middle and last are empty if not declared  
    protected string? FirstName{ get; set;}
    protected string? MiddleName {get;set;}
    protected string? LastName{get;set;}
    protected int UserId{get;}
    protected DateTime DateOfBirth{get;set;}
    protected char Gender{get;set;}

}