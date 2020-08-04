module cLua.AST

type Block =
  | VoidBlock of statements:Statement list
  | ReturnBlock of statements:Statement list * lastStatement:LastStatement

and Statement = 
  | Stub

and LastStatement =
  | Break
  | ReturnVoid
  | ReturnValues of returnValues:ExpressionList

and FunctionName =
  | Stub

and VarList =
  | Stub

and Var = 
  | Stub

and NameList = 
  | Stub

and ExpressionList = 
  | Stub

and Expression = 
  | Stub

and PrefixExpression =
  | Stub

and FunctionCall =
  | Stub

and Arguments = 
  | Stub

and Function = 
  | Stub

and FunctionBody = 
  | Stub

and ParameterList =
  | Stub

and TableConstructor =
  | Stub

and FieldList = 
  | Stub

and Field = 
  | Stub

and FieldSeparator = 
  | Stub

and BinaryOperator = 
  | Stub

and UnaryOperator = 
  | Stub