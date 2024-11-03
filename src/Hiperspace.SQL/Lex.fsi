
module Hiperspace.SQL.Lexer
open FSharp.Text.Lexing
open System
open Hiperspace.SQL.Parser/// Rule read
val read: lexbuf: LexBuffer<char> -> token
/// Rule read_string
val read_string: str: obj -> ignorequote: obj -> lexbuf: LexBuffer<char> -> token
/// Rule read_id_string
val read_id_string: str: obj -> ignorequote: obj -> lexbuf: LexBuffer<char> -> token
/// Rule comments
val comments: level: obj -> lexbuf: LexBuffer<char> -> token
