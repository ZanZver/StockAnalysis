module Global

type Page =
    | Home
    | Counter
    | About
    | StockView

let toHash page =
    match page with
    | About -> "#about"
    | Counter -> "#counter"
    | Home -> "#home"
    | StockView -> "#stockview"
    
