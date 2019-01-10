module RobotName
open System.Security.Cryptography    

let getRandomByte() =    
    let byteArray = Array.init(1) (fun _ -> (byte) 0)
    (new RNGCryptoServiceProvider()).GetBytes(byteArray)
    byteArray.[0]


let getRandomChar() =    
    let fCharIndex = (int) (getRandomByte()) / 10
    ['A'..'Z'].[fCharIndex].ToString() 

let generateRandomName() = 
    sprintf "%s%s%03i"  (getRandomChar()) (getRandomChar()) ((int) (getRandomByte()))
    

type Robot() =
    let mutable name_ = generateRandomName()
    member  this.Name  with get() = name_ and set(value) = name_ <- value 

    member this.Reset() = 
        this.Name <- generateRandomName()        


let mkRobot() = 
    Robot()

let name (robot : Robot) = 
    robot.Name

let reset (robot : Robot) = 
    robot.Reset() |> ignore
    robot