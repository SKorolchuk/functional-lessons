module Lessons.Bootstrap

    open Lessons.Framework
    open System
    open System.Windows.Forms
    open System.Collections.Generic
    open System.Linq

    let rec fact (a: int) =
        match a with
            | _ when a <= 1 -> 1
            | _ when a > 1 -> a*fact(a-1)
            | _ -> 0

    let initForm (title: string) =
        new Form(Text = title, Width = 200, Height = 200)

    let sampleFunc (a: int, b: int, c: int) =
        (a,b,c)

    let checkExitKey (key: char) =
        match key with
            | _ when key = 'w' -> true
            | _ when key = 'x' -> true
            | _ -> false

    [<EntryPoint>]
    let main(args: string[]) =
        printfn "Press button:"
        let key = Console.ReadKey()
        let a1,a2,a3 = sampleFunc(1,2,3)
        let checkRes = checkExitKey key.KeyChar

        let sampleFactParam : int = 5
        let res = fact(sampleFactParam)
        printfn "a1: %d a2: %d a2: %d you pressed key: %b factorial of %d is %d" a1 a2 a3 checkRes sampleFactParam res

        match BookSamples.fetch("http://tut.by") with
            | BookSamples.Some text -> printfn "%s" text
            | BookSamples.None -> printfn ""

        //let sampleForm = initForm("sample form")
        //sampleForm.ShowDialog();

        let rand = new System.Random((int)DateTime.Now.Ticks)

        let liste = [0..10]
        
        let trail l = 
            List.map (fun i -> rand.Next()) l

        liste 
        |> trail 
        |> List.iter (fun i -> printfn "%d" i)

        0