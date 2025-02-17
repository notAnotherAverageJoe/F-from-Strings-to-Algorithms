open System
open File1

printfn "Hello from F#"

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


printfn("--------------------------")
printfn "%s" greet



let rec calc () =
    printfn "Choose an operation: + - * / or Q to quit"
    let operation = Console.ReadLine().Trim().ToLower()

    if operation = "q" then
        printfn "Goodbye!"
    else
        printfn "Enter the first number: "
        let input1 = Console.ReadLine()

        printfn "Enter the second number: "
        let input2 = Console.ReadLine()

        match Int32.TryParse(input1), Int32.TryParse(input2) with
        | (true, x), (true, y) ->
            match operation with
            | "+" -> printfn "Result: %d" (x + y)
            | "-" -> printfn "Result: %d" (x - y)
            | "*" -> printfn "Result: %d" (x * y)
            | "/" -> 
                if y <> 0 then
                    printfn "Result: %d" (x / y)
                else
                    printfn "Error: Division by zero"
            | _ -> printfn "Invalid operation"
        | _ -> printfn "Invalid number input"

        calc ()  

calc ()  // Start the calculator loop
