module StockView.View

open Fable.React
open Fable.React.Props

let root =
  div
    [ ClassName "content" ]
    [ 
      table [][
          tr [][
              td [][
                  table [][
                      td [][str"logo"]
                      td [][str"Company name, share name"]
                      td [][str"Star"]
                  ]
              ]
          ]

          tr [][
              td [][
                p [][str "Graph"]
                table [][
                    td [][str"tab 1"]
                    td [][str"tab 2"]
                ]
              ]
              
              td [][str "Information"]
              
              td [][str "Subscribed shares"]
          ]

          tr [][
              td [][
                  p [][str "Similar shares"]
                  table [][
                      tr [][
                          td [][
                            p [][str "Based on sector:"]
                            table [][
                                tr [][str "based on sector1"]
                                tr [][str "based on sector2"]
                                tr [][str "based on sector3"]
                            ]
                          
                          ]
                          
                          td [][
                            p [][str "Based on growth:"]
                            table [][
                                tr [][str "based on growth1"]
                                tr [][str "based on growth2"]
                                tr [][str "based on growth3"]
                            ]
                          ]
                          
                          td [][
                            p [][str "Based on price:"]
                            table [][
                                tr [][str "based on price1"]
                                tr [][str "based on price2"]
                                tr [][str "based on price3"]
                            ]
                          ]
                      ]
                  ]
              ]
          ]
      ]

     ]
        

        