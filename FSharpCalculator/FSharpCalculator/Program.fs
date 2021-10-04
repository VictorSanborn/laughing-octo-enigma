// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
<<<<<<< HEAD
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


  
=======
>>>>>>> bc9fba2b63b988ebc5bc82b901f8c82436b0c8ff
    let name = Console.ReadLine()

    let add x y = x + y

    match name with
    //| "+" -> printfn "%i" add 1 1
    | "Name" -> printfn "Hello %s to Hacktoberfest!" name

<<<<<<< HEAD
=======
    
>>>>>>> bc9fba2b63b988ebc5bc82b901f8c82436b0c8ff
    0 // return an integer exit code
