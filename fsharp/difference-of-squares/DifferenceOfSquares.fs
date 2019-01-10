module DifferenceOfSquares

let squareOfSum (number: int): int = 
    [1..number] |> List.sum |> pown <| 2

let sumOfSquares (number: int): int = 
    [1..number] |> List.map( fun m -> m |> pown <| 2) |> List.sum

let differenceOfSquares (number: int): int = 
    (squareOfSum <| number) - (sumOfSquares number)