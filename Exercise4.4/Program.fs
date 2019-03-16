
let multiply acc hd = acc * hd
let add acc hd = acc + hd

let rec pclMap f = function
    | [] -> []
    | (hd :: tail) -> f hd :: pclMap f tail  
                    
pclMap add [0..6];;
pclMap multiply [0..6];;
