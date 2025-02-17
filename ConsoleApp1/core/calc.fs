module calc
open System

//let the system know this is a recursive function
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
