
let twoTupleItems = ("Valentines", 6)
let threeTupleItems = ("Valentines", 6, 50.46)

let temp = fst twoTupleItems; // when the tuple has 2 items

let  (_, todayTemp, _) = threeTupleItems //access element in the middle of the tuple

let listCons = 'b' :: ('c' :: ('d' :: []))

let addItem (list : char list) =
    list.Head :: 'g' :: list.Tail

let extractValue index tuple =
    let (a, b, c, d) = tuple
    match index with 
    | 0 -> a
    | 1 -> b
    | 2 -> c
    | 3 -> d
    | _ -> printfn "%i not in tupple" index


let numbersNear x = 
    [
        yield x - 1
        yield x
        yield x + 1
    ];;

 numbersNear 9

 let x = 
    [ let negate x = -x
      for i = 1 to 10 do
        if i % 2 = 0 then
            yield negate i
        else 
            yield i]
   
let negate x = -x
let y = [for i = 1 to 10 do if i % 2 = 0 then yield negate i else yield i]

let yieldBang = [for a = 1 to 5 do
                    match a with 
                    | 3 -> yield! ["p"; "c"; "l"]
                    | _ -> yield a.ToString()]


let isPrime (n : int) = 
    let rec loop iterator = 
        if iterator = n/2 then true
        elif n % iterator = 0 then false
        else loop (iterator + 1)
    in loop 1

let primesUnderMax (n:int) = [for i = 0 to n do if isPrime i then yield i]

let rec factorial (n: int) =
    match n with
    | 0 -> 1
    | _ -> n * factorial (n - 1)

let rec caseFactorial (n: int) =
    match n with
    | 0 -> 1
    | _ -> if n < 0 then
                failwith "You cannot input negative arguments in this function"
            else n * caseFactorial (n - 1)

