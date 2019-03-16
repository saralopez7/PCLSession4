
let multiply acc hd = acc * hd
let add acc hd = acc + hd

let rec pclFold funct (accumulator:int) (list: int list) = 
    match list with
    | [] -> accumulator
    | (hd :: restOfTheList) -> pclFold funct (funct accumulator hd) restOfTheList

pclFold multiply 10 [1 .. 3]
pclFold add 0 [1 .. 7]
