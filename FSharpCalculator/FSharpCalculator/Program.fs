// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let name = Console.ReadLine()

    let add x y = x + y

    match name with
    //| "+" -> printfn "%i" add 1 1
    | "Name" -> printfn "Hello %s to Hacktoberfest!" name

    
    0 // return an integer exit code
