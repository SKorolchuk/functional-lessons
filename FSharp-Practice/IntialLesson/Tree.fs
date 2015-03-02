module Tree

open System.Linq

type Tree =
    | Children of string * Tree list
    | Node of string

let rec check (treeRoot: Tree) (n: int) =
    match treeRoot with
        | Node x -> 
            printfn "%s%s"
                (match n with
                    | _ when n > 0 
                            -> Enumerable.Range(0, n).Select(fun x -> "---").Aggregate(fun x y -> x + y)
                    | _ -> ""
                )
                x
        | Children (node, children) ->
            printfn "%s%s"
                (match n with
                    | _ when n > 0 
                            -> Enumerable.Range(0, n).Select(fun x -> "---").Aggregate(fun x y -> x + y)
                    | _ -> ""
                )
                node
            (List.iter (fun x -> check x (n+1)) children)