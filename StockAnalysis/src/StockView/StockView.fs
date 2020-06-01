module StockView.View

open Fable.React
open Fable.React.Props

let model = "test ValuE"

let logoText = "logo value"
let companyText = "company value"
let shareText = "share value"
let starText = "star value"
let informationText = "some information"
let subscribedList =  [ "one "; "two "; "three " ]
let basedOnSector = [ "sec1, "; "sec2,"; "sec3," ]
let basedOnGrowth = [ "gr1 "; "gr2 "; "gr3 " ]
let basedOnPrice = [ "pr1 "; "pr2 "; "pr3 " ]


let root =
  div
    [ ClassName "content" ]
    [ 
      table [][
          tr [][
              td [][
                  table [][
                      td [][str logoText]
                      td [][str ([companyText; shareText] |> String.concat ",")]
                      td [][str starText]
                  ]
              ]
          ]

          tr [][
              td [][
                p [][str "Graph"]
                table [][
                    td [][
                        button [ClassName "buttonTab1"][str "tab1"]
                    ]
                    td [][
                        button [ClassName "buttonTab2"][str "tab2"]
                    ]
                ]
              ]
              
              td [][
                  p [][str "Information"]
                  p [][str informationText]
              ]
              
              td [][
                  p [][str "Subscribed shares"]
                  p [][str (subscribedList |> List.fold (+) "")]
              ]
          ]

          tr [][
              td [][
                  p [][str "Similar shares"]
                  table [][
                      tr [][
                          td [][
                            p [][str "Based on sector:"]
                            table [][
                                tr [][
                                    p [][str (basedOnSector |> List.fold (+) "")]
                                ]
                            ]
                          
                          ]
                          
                          td [][
                            p [][str "Based on growth:"]
                            table [][
                                    p [][str (basedOnGrowth |> List.fold (+) "")]
                            ]
                          ]
                          
                          td [][
                            p [][str "Based on price:"]
                            table [][
                                    p [][str (basedOnPrice |> List.fold (+) "")]
                            ]
                          ]
                      ]
                  ]
              ]
          ]
      ]

     ]
        

        