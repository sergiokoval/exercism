module Triangle

let processTriangleValues triangle =
    triangle|> Seq.groupBy(fun f -> f) |> Seq.map(fun ( _ ,value) -> Seq.length value)

let noZeros triangle =
     not << Seq.contains(0.0)  <| triangle 

let transformData (triangle : float list) = 
    [("side1", triangle.[0]); ("side2", triangle.[1]); ("side3", triangle.[2])]

let isTriangle triangle =    
    let data = transformData triangle
    
    data |> Seq.map(fun (k, v) -> k, v, data |> Seq.filter(fun (key, _)  -> key <> k ) |> Seq.map(fun (_,sumVal) -> sumVal) |> Seq.sum)
    |> Seq.map(fun (side, value, remainingSidesSum) -> side, value <= remainingSidesSum)
    |> Seq.map(fun (_, isTriangle) -> isTriangle)
    |> (not << Seq.contains(false)) 

let passValidation triangle =
    (noZeros triangle ) && (isTriangle triangle)

let equilateral triangle = 
    if passValidation triangle then
        triangle |> processTriangleValues |> Seq.contains(3)
    else
        false

let isosceles triangle = 
    if passValidation triangle then
        triangle |> processTriangleValues |> Seq.contains(2) || triangle |> processTriangleValues |> Seq.contains(3)
    else 
        false

let scalene triangle = 
    if passValidation triangle then
        triangle |> processTriangleValues |> Seq.length = 3
    else
        false