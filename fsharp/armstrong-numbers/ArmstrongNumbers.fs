module ArmstrongNumbers
open System

let isArmstrongNumber (number: int): bool = 
    let nums = number.ToString().ToCharArray() 
    nums|> List.ofSeq 
    |> List.map(fun (d) -> Math.Pow(Char.GetNumericValue(d), float nums.Length)) 
    |> List.sum = float number
    