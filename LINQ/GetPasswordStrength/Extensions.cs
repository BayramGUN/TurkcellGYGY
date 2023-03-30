namespace GetPasswordStrength;

public static class Extensions
{
    public static string GetPasswordStrength(this string value)
    {   
        string res = string.Empty;
        bool hasDigit = false;
        bool hasLetter = false;
        bool hasSymbol = false;
        bool hasLetterOrDigit = false;
        if(value.Length <= 6)
            res =  "Please enter new password includes min. 6 character";
        else
        {

        
        value.ToCharArray().ToList().ForEach(
        
        ch => {
        
        
                if(char.IsDigit(ch) & !hasDigit) 
                {
                    hasDigit = true;
                }
                if(char.IsLetter(ch) & !hasLetter) 
                {
                    hasLetter = true;
                }
                if(!char.IsLetterOrDigit(ch) & !hasSymbol) 
                {
                    hasSymbol = true;
                }
                else 
                    hasLetterOrDigit = true;
                //if(hasDigit & hasLetter & hasSymbol) break;


            });
        
        }
        

        if(hasLetter && hasDigit && hasSymbol)
            res = "Password is strength!";
        else if((hasLetter && hasDigit) || (hasSymbol && hasLetterOrDigit))
            res = "Password is mid!";
        else if(hasLetter || hasDigit || hasSymbol)
            res = "Password is weak!";

        return res;
    }
}