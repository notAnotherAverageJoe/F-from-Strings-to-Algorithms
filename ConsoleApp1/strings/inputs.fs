module inputs
open System

let greet() =
    //prompt user 
    printfn "Enter your first name: "
    //get user input 
    let firstName = Console.ReadLine()
    printfn "Enter your last name: "
    let lastName = Console.ReadLine()
    printfn "Enter your age: "
    let age = Console.ReadLine()
    //print all the user information into result and print it

    sprintf "Hello %s %s, you are %s years old" firstName lastName age


