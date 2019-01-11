module Grains

let square (n: int): Result<uint64,string> = 
    match n with
    | x when x <= 0 || x > 64 -> Error "square must be between 1 and 64"
    | _ ->  Result.Ok ((uint64)(2.0 ** (float(n) - 1.0)))

let total: Result<uint64,string> = 
    Ok (([0..63] |> Seq.map(fun e -> (uint64) (2.0 **  float(e))) |> Seq.sum))
    