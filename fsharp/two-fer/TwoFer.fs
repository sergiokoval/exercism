module TwoFer

let twoFer (input: string option): string = 
    match input with
    | input when input.IsNone || input.Value = "" ->  "One for you, one for me."
    | _  ->  sprintf "One for %s, one for me." input.Value