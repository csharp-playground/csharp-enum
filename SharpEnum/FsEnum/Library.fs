namespace FsEnum

open SharpEnum

type Class1() = 
    member this.X = "F#"


module Test =
    let a = SharpEnum.Letter.A

    let value = 
        match a with
        | Letter.A -> "A"
        | Letter.B -> "B"
        | _ -> "D"

