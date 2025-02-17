module coref
open System


//to add five 
let addIt n =
    n + 1
printfn "%d" (addIt 5)

//allows for easy dynamic addition 
printfn "Enter a Number: "
let input = Console.ReadLine()

match Int32.TryParse(input) with
| (true, n) -> printfn "Result: %d" (addIt n)
| (false, _) -> printfn "Invalid number"



