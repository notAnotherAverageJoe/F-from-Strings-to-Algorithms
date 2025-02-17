module coref
open System


//to add five 
let addIt n =
    n + 1
printfn "%d" (addIt 5)

//allows for easy dynamic addition 
printfn "Enter a Number: "
let input = Console.ReadLine()
// take the stirng input attempt to turn it into a number
// if it is a number add 1 to it
match Int32.TryParse(input) with
| (true, n) -> printfn "Result: %d" (addIt n)
| (false, _) -> printfn "Invalid number"

// we can also create new function for multiplication or any operation you can think of
// this function will multiply the input by 2
let multiplyIt n =
    n * 2
printfn "%d" (multiplyIt 5)



