namespace FsEnum

open SharpEnum

type Class1() = 
    member this.X = "F#"


module Test =
    let a = SharpEnum.Character.A

    let value = 
        match a with
        | Character.A -> "A"
        | Character.B -> "B"
        | Character.C -> "C"
        | _ -> "D"

