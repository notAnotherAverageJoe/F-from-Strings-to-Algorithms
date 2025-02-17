open System
open File1
open inputs

//simple call for printing from file1 inside strings

let hi = greetings
let bye = goodbye
printfn "%s" hi
printfn "%s" bye
printfn "---------------------------------"

printfn "Hello from F#"
printfn "---------------------------------"
//we can call our greet function from strings/input and save it to a variable
let userInfo = greet()
printf "%s" userInfo




