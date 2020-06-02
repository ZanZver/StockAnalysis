module Navbar.View

open Fable.React
open Fable.React.Props

let root =
    nav
        [ ClassName "navbar is-dark" ]
        [ div
            []
            [ div
                [ ClassName "navbar-brand" ]
                [ h1
                    [ ClassName "navbar-item title is-4" ]
                    [ str "Elmish" ] ]
            ] ]
