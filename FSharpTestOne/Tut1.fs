// Learn more about F# at: http://fsharp.org
// Fsharp cheatsheet: https://dungpa.github.io/fsharp-cheatsheet/
// Tutorials based on :Introduction to Functional Programming with F# https://www.youtube.com/watch?v=Teak30_pXHk&t=4s
module Tut1
// Tabs matters!


//-- specific decleration of mutability 
let mutable a = 10
a<-2

a //val it : int = 2

//-- dealing with lists
let items = [1..5]
let items2 =List.append items [6]
items // val it : int list = [1; 2; 3; 4; 5]
items2// val it : int list = [1; 2; 3; 4; 5; 6]


let prefix prefixStr baseStr = prefixStr + "," + baseStr
prefix "hi" "david" // val it : string = "hi,david"

let names = ["David";"Maria";"Alex"]
let prefixWithHello = prefix "Hello"
let exclaim s = s+ "!"

names |> Seq.map (prefix "Hello") // val it : seq<string> = seq ["Hello,David"; "Hello,Maria"; "Hello,Alex"]

names |> Seq.map prefixWithHello |> Seq.map exclaim // val it : seq<string> = seq ["Hello,David!"; "Hello,Maria!"; "Hello,Alex!"]

let shout s = s|> Seq.map prefixWithHello |> Seq.map exclaim
let shout2 = prefixWithHello >> exclaim

names |> shout |> Seq.sort // val it : seq<string> = seq ["Hello,Alex!"; "Hello,David!"; "Hello,Maria!"]
names |> Seq.map shout2// val it : seq<string> = seq ["Hello,David!"; "Hello,Maria!"; "Hello,Alex!"]

let hellos = 
    names 
    |> Seq.map (fun x -> printfn "Mapped over %s" x; shout2 x)
    |> Seq.sort
    |> Seq.iter (printfn "%s")
                                (*
                                Mapped over David
                                Mapped over Maria
                                Mapped over Alex
                                Hello,Alex!
                                Hello,David!
                                Hello,Maria!
                                val hellos : unit = ()
                                *)



[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code