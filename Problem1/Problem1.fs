open System

let sumFib maxNum =
    let rec fib l max =
        match l with
        | [] -> fib (1::l) max
        | [a] -> fib (1::l) max
        | _ when ((List.head l) + List.head(List.tail l)) < max -> 
            fib (((List.head l) + List.head(List.tail l))::l) max
        | _ -> l
    (fib [] maxNum) |> List.filter (fun a -> a % 2 = 0) |> List.sum

let sumFibBillion =
    sumFib 1000000

[<EntryPoint>]
let main argv =
    0
