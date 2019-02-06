// Learn more about F# at http://fsharp.org
module a.Tut1
(*

let mutable a = 10
a<-2

let items = [1..5]
let items2 =List.append items [6]
items|> ignore
items2|> ignore


let prefix prefixStr baseStr = prefixStr + "," + baseStr
prefix "hi" "david"

let names = ["David";"Maria";"Alex"]
let prefixWithHello = prefix "Hello"
let exclaim s = s+ "!"

names |> Seq.map (prefix "Hello")

names |> Seq.map prefixWithHello |> Seq.map exclaim
let shout s = s|> Seq.map prefixWithHello |> Seq.map exclaim
let shout2 = prefixWithHello >> exclaim

names |> shout |> Seq.sort
names |> Seq.map shout2

let hellos = 
    names 
    |> Seq.map (fun x -> printfn "Mapped over %s" x; shout2 x)
    |> Seq.sort
    |> Seq.iter (printfn "%s")

hellos

*)

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code