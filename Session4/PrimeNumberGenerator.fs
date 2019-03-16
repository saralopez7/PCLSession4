module PrimeNumberGenerator

let primesUnder max = 
    [
    for n in 1 .. max do
        let factorsOfN = [for i in 1 .. n do if n % i = 0 then yield i]
        // n is prime if its only factors are 1 and n
        if List.length factorsOfN = 2 then yield n
    ];; 
    
primesUnder 50;;