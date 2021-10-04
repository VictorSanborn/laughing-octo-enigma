// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
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


  
    let name = Console.ReadLine()

    let add x y = x + y

    match name with
    //| "+" -> printfn "%i" add 1 1
    | "Name" -> printfn "Hello %s to Hacktoberfest!" name

    0 // return an integer exit code
