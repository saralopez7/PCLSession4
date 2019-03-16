let pclEven (element:int) = (element % 2) = 0
let notEqualTo5 (element:int) = element <> 5
let equalTo5 (element:int) = element = 5

//let rec pclFilter (filter: string) (ls: int list) =
//    match ls with 
//    | [] -> []
//    | hd :: tail -> match filter with 
//                    | "pclEven" -> match (pclEven hd) with
//                                        | true -> hd :: pclFilter filter tail
//                                        | _ -> pclFilter filter tail
//                    | "notEqualTo5" -> match (notEqualTo5 hd) with
//                                        | true -> hd :: pclFilter filter tail
//                                        | _ -> pclFilter filter tail
//                    | "equalTo5" -> match (notEqualTo5 hd) with
//                                        | false -> hd :: pclFilter filter tail
//                                        | _ -> pclFilter filter tail
 
let rec pclFilter2 predicate (ls: int list) =
    match ls with 
    | [] -> []
    | hd :: tail -> if predicate hd then hd :: pclFilter2 predicate tail
                    else pclFilter2 predicate tail

let even = pclFilter2 pclEven [1..6]
let equalToFive  = pclFilter2 equalTo5 [1..6]
let differentThan5 = pclFilter2 notEqualTo5 [1..6]
