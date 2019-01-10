module SpaceAge

type Planet =    
     
    |Mercury 
    |Venus   
    |Earth   
    |Mars    
    |Jupiter 
    |Saturn  
    |Uranus  
    |Neptune  

let calculateAge seconds ratio =
    let earthOrbitPerInSec = 31557600.0
    float seconds / (earthOrbitPerInSec * ratio)

let age (planet: Planet) (seconds: int64): float = 
    
    match planet with
        | planet when planet = Mercury -> calculateAge seconds 0.2408467
        | planet when planet = Earth -> calculateAge seconds 1.0
        | planet when planet = Venus -> calculateAge seconds 0.61519726
        | planet when planet = Mars -> calculateAge seconds 1.8808158
        | planet when planet = Jupiter -> calculateAge seconds  11.862615
        | planet when planet = Saturn -> calculateAge seconds 29.447498
        | planet when planet = Uranus -> calculateAge seconds  84.016846 
        | planet when planet = Neptune -> calculateAge seconds 164.79132
        | _ -> failwith "Can't recognize the planet!"
    
    