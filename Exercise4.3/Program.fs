let pclIncList list = [for item in list do yield item + 1]
pclIncList [2; 3; 1; 4]

let rec recursivePclIncList (list: int list) = 
    match list with
    | [] -> []
    | (hd :: tail) -> hd + 1 :: recursivePclIncList (tail) 

recursivePclIncList [2; 3; 1; 4] ;;