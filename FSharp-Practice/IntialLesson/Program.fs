module Lessons.Bootstrap

    open Lessons.Framework
    open System
    open System.Windows.Forms
    open System.Collections.Generic
    open System.Linq
    open Tree
    open Vector

    [<EntryPoint>]
    let main(args: string[]) =
        BookSamples.sampleInputExample

        match BookSamples.fetch("http://tut.by") with
            | BookSamples.Some text -> printfn "%s" text
            | BookSamples.None -> printfn ""

        BookSamples.simpleListProcessing

        let treeStruct =
            Children ("root",
                [
                    Children ("s1",
                        [
                            Node "a";
                            Node "b"
                        ]
                    );
                    Children ("s2",
                        [
                            Node "c";
                            Node "d"
                        ]
                    );
                ])

        let result = Tree.check treeStruct 0

        let sampleVect = new Vector.Vector4(1.,2.,3.,4.)

        let anotherVect = new Vector.Vector4(2.,3.,0.,7.)

        let sumVect = sampleVect + anotherVect;

        let mulSubject = sampleVect * anotherVect;

        printfn "sampleVect: %s \n length of sampleVect: %f \n sumVect: %s \n mulSubject: %f" 
            (sampleVect |> Vector.Vector4.ToString)
            !!sampleVect
            (sumVect |> Vector.Vector4.ToString)
            mulSubject
        0