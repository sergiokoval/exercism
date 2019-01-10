module PhoneNumber

let clean input = 
    match input with
    | i when Seq.length <| i <> 11  -> "Can't be!"