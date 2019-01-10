module BinarySearchTree

type Node() =
    member val NodeValue = Option<int>.None with get,set
    member val Left = Option<Node>.None with get, set
    member val Right = Option<Node>.None with get, set

let rec populateTree (value: int, node:Node) =
    if node.NodeValue.IsSome then
        if value <= node.NodeValue.Value then
            if node.Left.IsNone then
                node.Left <- Some(Node())

            populateTree(value, node.Left.Value)

        else if value >= node.NodeValue.Value then
                if node.Right.IsNone then
                    node.Right <- Some(Node())

                populateTree(value, node.Right.Value)
     else 
        node.NodeValue <- Some(value)
 
let rec convertTreeToSeq (node:Node) =        
       seq {
            if node.NodeValue.IsSome then yield node.NodeValue.Value
            if node.Left.IsSome then yield! convertTreeToSeq(node.Left.Value)           
            if node.Right.IsSome then yield! convertTreeToSeq(node.Right.Value)
       }

let left (node:Node )  = 
    node.Left

let right (node:Node) = 
    node.Right

let data (node: Node) = 
    node.NodeValue.Value

let create items = 
    let root = Node()   

    for i in items do
        populateTree(i,root)          
    root        

let sortedData node =   
    node |> convertTreeToSeq |> Seq.sort |> List.ofSeq