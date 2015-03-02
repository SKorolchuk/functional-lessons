module Vector

open System

type Vector4(x: double, y: double, z: double, w: double) =
    member this.X = x
    member this.Y = y
    member this.Z = z
    member this.W = w

    static member (+) (subject: Vector4, predicate: Vector4) =
        new Vector4(subject.X + predicate.X,
         subject.Y + predicate.Y,
         subject.Z + predicate.Z,
         subject.W + predicate.W)

    static member (*) (subject: Vector4, predicate: Vector4) =
        subject.X * predicate.X +
        subject.Y * predicate.Y +
        subject.Z * predicate.Z +
        subject.W * predicate.W

    static member (!!) (subject: Vector4) =
        subject.X * subject.X +
        subject.Y * subject.Y +
        subject.Z * subject.Z +
        subject.W * subject.W
        |> Math.Sqrt

    static member ToString (subject: Vector4) =
        System.String.Format("x = {0}; y = {1}; z = {2}; w = {3}",
            subject.X,
            subject.Y,
            subject.Z,
            subject.W)