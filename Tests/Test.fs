open System
open Problem1
open Problem3
open NUnit.Framework
open FsUnit

[<Test>]
let ``test sum fib 1``() =
    sumFib 10 |> should equal 10

let ``test sum fib 2``() =
    sumFib 30 |> should equal 10

let ``test sum fib 3``() =
    sumFib 40 |> should equal 44

let ``test sum fib of billion``() =
    sumFibBillion |> should equal 1089154

let ``test of stack 1``() =
    let s = Stack()
    s.Push(10)
    s.Push(20)
    s.Push(15)
    s.Pop()
    s.Pop() |> should equal 20

let ``test of stack 2``() =
    let s = Stack()
    (s.Pop() |> ignore) |> should throw typeof<ArgumentException>
    
let ``test of stack 3``() =
    let s = Stack()
    s.Push(1)
    s.Push(2)
    s.Push(5)
    s.Pop() 
    s.Pop()
    s.Pop()
    s.IsEmpty() |> should equal true

[<EntryPoint>]
let main argv =
    ``test sum fib 1``()
    ``test sum fib 2``()
    ``test sum fib 3``()
    ``test sum fib of billion``()
    ``test of stack 1``()
    ``test of stack 2``()
    ``test of stack 3``()
    0
