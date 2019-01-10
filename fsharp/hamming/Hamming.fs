module Hamming

let distance (strand1: string) (strand2: string): int option  =
       match strand1, strand2 with
          | s1, s2 when s1.Length <> s2.Length -> None
          | s1, s2 when s1.Length = 0 || s2.Length = 0 -> Some(0)
          | _ -> Seq.zip strand1 strand2 |> Seq.filter(fun (s1, s2) -> s1 <> s2) |> Seq.length |> Some      