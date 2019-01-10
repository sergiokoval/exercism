module SumOfMultiples

let isMultipleOf(numList : int list) (ofNumber) : bool =
    numList 
    |> List.filter(fun(f)-> (ofNumber % f) = 0 ) 
    |> List.length > 0    

let sum (numbers: int list) (upperBound: int): int =     
    List.ofSeq [1.. upperBound - 1] 
    |> List.filter( fun (n) ->  isMultipleOf numbers n)
    |> List.sum
    