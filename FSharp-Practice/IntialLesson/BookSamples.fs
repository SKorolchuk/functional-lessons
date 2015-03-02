module BookSamples

open System
open System.IO
open System.Windows.Forms

    type 'T option =
    | None
    | Some of 'T

    let http (url: string) =
        let req = System.Net.WebRequest.Create(url)
        let resp = req.GetResponse()
        let stream = resp.GetResponseStream()
        let reader = new StreamReader(stream)
        let html = reader.ReadToEnd()
        resp.Close()
        html

    let fetch url =
        try Some (http url)
        with :? System.Net.WebException -> None

    let trimAndClearSpaces (str: string) =
        str.Replace(' ', '_')

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

    let sampleInputExample =
        printfn "Press button:"
        let key = Console.ReadKey()
        let a1,a2,a3 = sampleFunc(1,2,3)
        let checkRes = checkExitKey key.KeyChar

        let sampleFactParam : int = 5
        let res = fact(sampleFactParam)
        printfn "a1: %d a2: %d a2: %d you pressed key: %b factorial of %d is %d" a1 a2 a3 checkRes sampleFactParam res

    let simpleListProcessing =
        //let sampleForm = initForm("sample form")
        //sampleForm.ShowDialog();

        let rand = new System.Random((int)DateTime.Now.Ticks)

        let liste = [0..10]
        
        let trail l = 
            List.map (fun i -> rand.Next()) l

        liste 
        |> trail 
        |> List.iter (fun i -> printfn "%d" i)

    let sampleAggregationThroughCollection list =
        list
        |> List.filter (fun x -> x % 2 = 0)
        |> List.map (fun x -> (x + x) * 2)
        |> List.sum