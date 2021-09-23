// Learn more about F# at http://fsharp.org

open System

// varible del resultado 
let mutable mul = 0
//funcion multiplicacion de 2 numeros
let multipli (a: int, b: int) =
    for i in 1..b do
       mul <- a + mul
    mul


[<EntryPoint>]
let main argv =
    printfn "****Multiplicacion de 2 numeros con sumas sucesivas****"
    printfn "Introduzca los dos numeros a multiplicar..."
    let num1 = int32(Console.ReadLine())
    let num2 = int32(Console.ReadLine())
    let c = multipli (num1, num2)
    printf "La Multiplicacion es %i" c
    Console.ReadKey()|> ignore
    0 // return an integer exit code
