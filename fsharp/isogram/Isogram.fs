module Isogram

let isIsogram (str :string) = 
    let chars = str.ToLower() |> Seq.filter(fun f -> Seq.contains(f) <| ['a'..'z']) 

    chars |> Seq.groupBy( fun (g) -> g.ToString()) 
    |> Seq.map(fun (a,b) -> a, Seq.length b)
    |> Seq.filter (fun (_, b) -> b = 1)
    |> Seq.length = Seq.length chars