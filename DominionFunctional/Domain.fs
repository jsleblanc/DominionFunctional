module Domain

type Coins = Coins of int
type VictoryPoints = VictoryPoints of int
type Actions = Actions of int
type Buys = Buys of int

type CardTypes =
    | Action 
    | Treasure of Coins
    | Curse
    | Victory
    | Attack
    | Duration
    | Reaction

type Card = {
    Name : string
    Cost : Coins
    Types : CardTypes list
}

type Deck = Card seq
type Hand = Card seq
type Pile = Card seq

type Supply = {
    TreasureCard : Pile seq
    VictoryCard : Pile seq
    CurseCards : Pile
    KingdomCards : Pile seq
}

type Board = {
    Trash : Card seq
    Supply : Supply
}

type Player = {
    Deck : Deck
    Hand : Hand
    Discard : Pile
}

type Turn = {
    ActionsRemaining : Actions
    BuysRemaining : Buys
}

type Cards = 
    | VictoryCard of Points:int
    | ActionCard
    | TreasureCard of Value:int
    //| Curse
    //| Witch of Action 

