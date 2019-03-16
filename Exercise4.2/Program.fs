
let multiply acc hd = acc * hd
let add acc hd = acc + hd

let rec pclFoldBack funct (accumulator:int) (list: int list) = 
    match list with
    | [] -> accumulator
    | (hd :: restOfTheList) -> funct hd (pclFoldBack funct accumulator restOfTheList)

pclFoldBack multiply 10 [1 .. 3];;                        

let sumList list = List.fold (fun acc elem -> acc * elem) 10 list
printfn "Sum of the elements of list %A is %d." [ 3; 2; 1 ] (sumList [ 3; 2; 1 ])