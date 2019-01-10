module Gigasecond

open System

let add (beginDate :DateTime) = 
    let secondsToAdd = (10.00 **9.00) 
    secondsToAdd |> beginDate.AddSeconds 