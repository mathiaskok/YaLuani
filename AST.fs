module YaLuani.AST

type Chunk = 
  | CBlock of block:Block

and Block =
  | Block of statements:Statement list * returnStatement:ReturnStatement option

and Statement = 
  | SNoOp
  | SAssignment of varList:Var list * exprList:Expression list
  | SFuncCall of funcCall:FunctionCall
  | SBreak
  | SBlock of block:Block
  | SWhile of whileExpr:Expression * whileBlock:Block
  | SRepeat of repeatBlock:Block * repeatExpr:Expression
  | CIfElse of ifPart:ConditionalBlock * elseIfParts:ConditionalBlock list * elsePart:Block option

and ConditionalBlock = {
  Cond:Expression
  Block:Block
}

and ReturnStatement =
  | Return of returnValues:Expression list

and FunctionName =
  | FunctionName of funcPrefix:string list * funcName:string

and Var = 
  | SimpleVar of name:string
  | IndexVar of tableExpr:Expression * indexExpr:Expression

and Expression = 
  | ENil
  | ETrue
  | EFalse
  | ENumeral of num:double
  | EString of str:string
  | EFuncDef of funcDef:FunctionDefinition
  | EVar of var:Var
  | EFuncCall of funcCall:FunctionCall
  | ETableCtor of tableFields:Field list
  | EBinaryOp of leftExpr:Expression * op:BinaryOperator * rightExpr:Expression
  | EUnaryOp of op:UnaryOperator * unaryExpr:Expression

and FunctionCall =
  | FunctionCall of funcExpr:Expression * args:Arguments
  | MethodCall of objExpr:Expression * methodName:string * args:Arguments

and Arguments = 
  | ExpListArgs of args:Expression list
  | TableArgs of table:Field list

and FunctionDefinition = 
  | FunctionDefinition of parameters:ParameterList * body:Block

and ParameterList =
  | Params of names:string list
  | ParamsWithCatchAll of names:string list

and Field = 
  | TableField of indexExpr:Expression * valueExpr:Expression
  | ArrayField of expr:Expression

and BinaryOperator = 
  | BPlus
  | BMinus
  | BMult
  | BDivFloat
  | BDivFloor
  | BExp
  | BModulo
  | BBitwiseAnd
  | BBitwiseXOr
  | BBiwiseOr
  | BRightShift
  | BLeftShift
  | BConcat
  | BLessThan
  | BLessOrEqual
  | BGreaterThan
  | BGreaterOrEqual
  | BEqual
  | BNotEqual
  | BAnd
  | BOr

and UnaryOperator = 
  | UMinus
  | UNot
  | ULength
  | UBitwiseNot