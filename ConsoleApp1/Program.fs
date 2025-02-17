open System
open File1
open inputs

printfn "Hello from F#"
printfn "---------------------------------"
//we can call our greet function from strings/input and save it to a variable
let userInfo = greet()
printf "%s" userInfo




