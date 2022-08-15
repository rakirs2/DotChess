# CSharpChess

## Invariants
* every piece/object should be derived from something else?
* have tests sth any code change breaks tests?
* try to limit comments

## Todos

- [x] create a board
- [x] print board
- [] convert from files to ranks 
- [ ] print board by square
- [ ] create piece class -- try predicting needed field
- [ ] create pawns

## Real Todos
I realized my approach wasn't really getting anywhere. Instead, I'm going to start with all of the pieces, just keep track of the pieces --> basically track changes and store the info about move possibilities within the pieces
- instantiate pieces in a hashmap or a 

## Iteration 3
- move logic shouldn't necessarily be at the piece level. Maybe just store piece tracker, let it call possible things and then go from there