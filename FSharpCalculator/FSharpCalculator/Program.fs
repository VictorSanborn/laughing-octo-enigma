// Learn more about F# at http://fsharp.org

open System

let square y = 4 * 4
let negative x y = x - y

let fib x =
    let n = Console.ReadLine()
    let mutable i = 1
    let mutable j = 1
    printfn "%i" i
    printfn "%i" j
    for k in 1 .. int(n) do 
        let c = i + j
        printfn "%i" c
        i <- j 
        j <- c

[<EntryPoint>]
let main argv = 

    match Console.ReadLine() with
    | "Fib" -> fib 1
    | "Welcome" -> printfn "Welcome to Hacktoberfest!"
    | "Square" -> printfn "%i" (square 4)
    | "Negative" -> printfn "%i" (negative 4 2)

    0 // return an integer exit code

