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

//example data
let testDataSymbol              = "AAPL"
let testDataPrice               = 310.33
let testDataBeta                = 1.228499
let testDataVolAvg              = 36724977
let testDataMktCap              = 1.37587904E12
let testDataLastDiv             = 2.92
let testDataRange               = "149.22-312.67"
let testDataChanges             = 0.7
let testDataChangesPercentage   = "(+0.23)"
let testDataCompanyName         = "Apple Inc."
let testDataExchange            = "Nasdaq Global Select"
let testDataIndustry            = "Computer Hardware"
let testDataWebsite             = "http://www.apple.com/"
let testDataDescription         = "Apple Inc is designs, manufactures and markets mobile communication and media 
                                   devices and personal computers, and sells a variety of related software, services, 
                                   accessories, networking solutions and third-party digital content and applications."
let testDataCeo                 = "Timothy D. Cook"
let testDataSector              = "Technology"
let testDataImage               = "https://financialmodelingprep.com/images-New-jpg/AAPL.jpg"

//explanations
let explanationPrice            ="price is showing how much each share is worth in US dollars"
let explanationBeta             ="measures the volatility of an individual stock compared to the systematic risk of the entire market"
let explanationVolAvg           ="number of shares traded within a day in a given stock"
let explanationMktCap           ="total value of all a company's shares of stock"
let explanationLastDiv          ="distribution of a portion of the company's earnings, decided and managed by the company’s board of directors, and paid to a class of its shareholders"
let explanationRange            ="difference between the low and high prices for a security or index over a specific time period"
let explanationChanges          ="measures of supply and demand"
let explanationChangesPercentage="measures of supply and demand in %"
let explanationExchange         ="a market in which securities are bought and sold"
let explanationIndustry         ="an industry is a group of companies that are related based on their primary business activities"
let explanationWebsite          ="where company can be found"
let explanationCEO              ="A chief executive officer, or just chief executive, is the most senior corporate, executive, or administrative officer in charge of managing an organization – especially an independent legal entity such as a company or nonprofit institution"
let explanationSector           ="a sector is an area of the economy in which businesses share the same or a related product or service"


let root =
  div
    [  ]
    [ 
      table [ Style[ CSSProp.Width "width:100%" ]][
          tr [][
              td [ Style[ CSSProp.ColumnSpan "3"]][
                  table [][
                      (*
                      td [][str logoText]
                      td [][str ([companyText; shareText] |> String.concat ",")]
                      td [][str starText]
                      *)
                      //td [][img [ Src testDataImage  ] ]
                      td[][img [Src testDataImage; Style [CSSProp.Height "40px"]]]
                      td [][str ([testDataCompanyName; testDataSymbol] |> String.concat ", ")]
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
                  //p [][str informationText]
                  p [][str (["Price"; testDataPrice.ToString()] |> String.concat ": ")]
                  p [][str explanationPrice]
                  
                  p [][str (["Beta"; testDataBeta.ToString()] |> String.concat ": ")]
                  p [][str explanationBeta]
                  
                  p [][str (["VolAvg"; testDataVolAvg.ToString()] |> String.concat ": ")]
                  p [][str explanationVolAvg]
                  
                  p [][str (["MktCap"; testDataMktCap.ToString()] |> String.concat ": ")]
                  p [][str explanationMktCap]    
                  
                  p [][str (["LastDiv"; testDataLastDiv.ToString()] |> String.concat ": ")]
                  p [][str explanationLastDiv]

                  p [][str (["Range"; testDataRange.ToString()] |> String.concat ": ")]
                  p [][str explanationRange]

                  p [][str (["Changes"; testDataChanges.ToString()] |> String.concat ": ")]
                  p [][str explanationChanges]
                  
                  p [][str (["\nChangesPercentage"; testDataChangesPercentage.ToString()] |> String.concat ": ")]
                  p [][str explanationChangesPercentage]
                  
                  p [][str (["Exchange"; testDataExchange.ToString()] |> String.concat ": ")]
                  p [][str explanationExchange]
                  p [][str "\n "]
                  p [][str (["Industry"; testDataIndustry.ToString()] |> String.concat ": ")]
                  p [][str explanationIndustry]
                  
                  p [][str (["Website"; testDataWebsite.ToString()] |> String.concat ": ")]
                  p [][str explanationWebsite]
                  
                  p [][str (["CEO"; testDataCeo.ToString()] |> String.concat ": ")]
                  p [][str explanationCEO]
                  
                  p [][str (["Sector"; testDataSector.ToString()] |> String.concat ": ")]
                  p [][str explanationSector]
              ]
              
              td [][
                  p [][str "Subscribed shares"]
                  p [][str (subscribedList |> List.fold (+) "")]
              ]
          ]

          tr [][
              td [ Style[ CSSProp.ColumnSpan "3"]][
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
        

        