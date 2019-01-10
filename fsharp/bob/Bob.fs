module Bob

open System.Text.RegularExpressions
open System


let response (input: string): string = 
    if Regex.IsMatch(input,  @"^\b[A-Z\s]*\b\?$") then "Calm down, I know what I'm doing!"
    else if Regex.IsMatch(input, @"^\b[A-Z\s]*\b$", RegexOptions.Singleline) then "Whoa, chill out!"
    else if Regex.IsMatch(input, @"\?[\s]*$", RegexOptions.Singleline) then "Sure." 
    else if Regex.IsMatch(input, @"^[\s]{2,}$", RegexOptions.Singleline) then "Fine. Be that way!"
    else
        match input with  
           | input when input.ToUpper().Contains("Let's".ToUpper()) -> "Whatever."
           | input when input.Contains("!") -> "Whoa, chill out!"          
           | input when input.Equals("") -> "Fine. Be that way!"
           | _ -> "Whatever."

   