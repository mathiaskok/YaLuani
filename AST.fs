module YaLuani.AST

type Chunk = 
  | CBlock of block:Block

and Block =
  | VoidBlock of statements:Statement list
  | ReturnBlock of statements:Statement list * returnStatement:ReturnStatement

and Statement = 
  | Stub

and ReturnStatement =
  | ReturnVoid
  | ReturnValues of returnValues:Expression list

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
  //TODO

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