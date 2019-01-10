module Pangram

let isPangram (input: string): bool = 
    let letters = ['A'..'Z']
    letters |> List.filter(fun (p) -> input.ToUpper().Contains(p)) 
    |> List.length  = (letters |> List.length)

    