namespace SchoolManagement.ClientModule.Validations;

public static class PersonInputValidation
{
    public static bool IsIdentityNumberValid(this long identity) =>
                (identity > 9999999999 & identity < 99999999999 ) ?
                true : false;
    
    public static bool IsNameOrSurnameValid(this string name)
    {
        name.ToCharArray();
        foreach(char ch in name)
            if(!char.IsLetter(ch) & !char.IsWhiteSpace(ch)) return false; 
        return true;
    }
}