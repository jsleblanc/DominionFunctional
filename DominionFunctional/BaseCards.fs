module BaseCards

open Domain

let Curse = {
    Name = "Curse"
    Cost = Coins 0
    Types = [ Curse ]
}

let Estate = {
    Name = "Estate"
    Cost = Coins 2
    Types = [ Victory ]
}

let Duchy = {
    Name = "Duchy"
    Cost = Coins 5
    Types = [ Victory ]
}

let Province = {
    Name = "Province"
    Cost = Coins 8
    Types = [ Victory ]
}

let Copper = {
    Name = "Copper"
    Cost = Coins 0
    Types = [ Treasure(Coins(1))]
}

let Silver = {
    Name = "Silver"
    Cost = Coins 3
    Types = [ Treasure(Coins(2))]
}

let Gold = {
    Name = "Gold"
    Cost = Coins 6
    Types = [ Treasure(Coins(3))]
}

