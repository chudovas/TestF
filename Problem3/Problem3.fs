open System

type Stack() =
    let mutable stack = []
    let push(el) =
        stack <- el::stack

    let isEmpty() =
        stack |> List.isEmpty

    let pop() =
        match stack with
        | []   -> (raise (ArgumentException("Empty stack!")))
        | a::b -> 
            stack <- b
            a    

    member this.Push(el) = push(el)
    member this.Pop() = pop()
    member this.IsEmpty() = isEmpty()

[<EntryPoint>]
let main argv =
    0 
