<script>
import Square from "../components/Shared/Square.vue";

export default {
  name: "Chessboard",
  components: {
    Square,
  },
  data() {
    return {
      squares: [
        {
          CoordinatePosition: "A1",
          Id: 0,
          color: "black",
          Piece: { Player: 1, color: "white", PieceType: "Rook" },
        },
        {
          CoordinatePosition: "A2",
          Id: 1,
          color: "white",
          Piece: { Player: 1, color: "white", PieceType: "Pawn" },
        },
        { CoordinatePosition: "A3", Id: 2, color: "black", Piece: null },
        { CoordinatePosition: "A4", Id: 3, color: "white", Piece: null },
        { CoordinatePosition: "A5", Id: 4, color: "black", Piece: null },
        { CoordinatePosition: "A6", Id: 5, color: "white", Piece: null },
        {
          CoordinatePosition: "A7",
          Id: 6,
          color: "black",
          Piece: { Player: 2, color: "black", PieceType: "Pawn" },
        },
        {
          CoordinatePosition: "A8",
          Id: 7,
          color: "white",
          Piece: { Player: 2, color: "black", PieceType: "Rook" },
        },
        {
          CoordinatePosition: "B1",
          Id: 8,
          color: "white",
          Piece: { Player: 1, color: "white", PieceType: "Knight" },
        },
        {
          CoordinatePosition: "B2",
          Id: 9,
          color: "black",
          Piece: { Player: 1, color: "white", PieceType: "Pawn" },
        },
        { CoordinatePosition: "B3", Id: 10, color: "white", Piece: null },
        { CoordinatePosition: "B4", Id: 11, color: "black", Piece: null },
        { CoordinatePosition: "B5", Id: 12, color: "white", Piece: null },
        { CoordinatePosition: "B6", Id: 13, color: "black", Piece: null },
        {
          CoordinatePosition: "B7",
          Id: 14,
          color: "white",
          Piece: { Player: 2, color: "black", PieceType: "Pawn" },
        },
        {
          CoordinatePosition: "B8",
          Id: 15,
          color: "black",
          Piece: { Player: 2, color: "black", PieceType: "Knight" },
        },
        {
          CoordinatePosition: "C1",
          Id: 16,
          color: "black",
          Piece: { Player: 1, color: "white", PieceType: "Bishop" },
        },
        {
          CoordinatePosition: "C2",
          Id: 17,
          color: "white",
          Piece: { Player: 1, color: "white", PieceType: "Pawn" },
        },
        { CoordinatePosition: "C3", Id: 18, color: "black", Piece: null },
        { CoordinatePosition: "C4", Id: 19, color: "white", Piece: null },
        { CoordinatePosition: "C5", Id: 20, color: "black", Piece: null },
        { CoordinatePosition: "C6", Id: 21, color: "white", Piece: null },
        {
          CoordinatePosition: "C7",
          Id: 22,
          color: "black",
          Piece: { Player: 2, color: "black", PieceType: "Pawn" },
        },
        {
          CoordinatePosition: "C8",
          Id: 23,
          color: "white",
          Piece: { Player: 2, color: "black", PieceType: "Bishop" },
        },
        {
          CoordinatePosition: "D1",
          Id: 24,
          color: "white",
          Piece: { Player: 1, color: "white", PieceType: "Queen" },
        },
        {
          CoordinatePosition: "D2",
          Id: 25,
          color: "black",
          Piece: { Player: 1, color: "white", PieceType: "Pawn" },
        },
        { CoordinatePosition: "D3", Id: 26, color: "white", Piece: null },
        { CoordinatePosition: "D4", Id: 27, color: "black", Piece: null },
        { CoordinatePosition: "D5", Id: 28, color: "white", Piece: null },
        { CoordinatePosition: "D6", Id: 29, color: "black", Piece: null },
        {
          CoordinatePosition: "D7",
          Id: 30,
          color: "white",
          Piece: { Player: 2, color: "black", PieceType: "Pawn" },
        },
        {
          CoordinatePosition: "D8",
          Id: 31,
          color: "black",
          Piece: { Player: 2, color: "black", PieceType: "Queen" },
        },
        {
          CoordinatePosition: "E1",
          Id: 32,
          color: "black",
          Piece: { Player: 1, color: "white", PieceType: "King" },
        },
        {
          CoordinatePosition: "E2",
          Id: 33,
          color: "white",
          Piece: { Player: 1, color: "white", PieceType: "Pawn" },
        },
        { CoordinatePosition: "E3", Id: 34, color: "black", Piece: null },
        { CoordinatePosition: "E4", Id: 35, color: "white", Piece: null },
        { CoordinatePosition: "E5", Id: 36, color: "black", Piece: null },
        { CoordinatePosition: "E6", Id: 37, color: "white", Piece: null },
        {
          CoordinatePosition: "E7",
          Id: 38,
          color: "black",
          Piece: { Player: 2, color: "black", PieceType: "Pawn" },
        },
        {
          CoordinatePosition: "E8",
          Id: 39,
          color: "white",
          Piece: { Player: 2, color: "black", PieceType: "King" },
        },
        {
          CoordinatePosition: "F1",
          Id: 40,
          color: "white",
          Piece: { Player: 1, color: "white", PieceType: "Bishop" },
        },
        {
          CoordinatePosition: "F2",
          Id: 41,
          color: "black",
          Piece: { Player: 1, color: "white", PieceType: "Pawn" },
        },
        { CoordinatePosition: "F3", Id: 42, color: "white", Piece: null },
        { CoordinatePosition: "F4", Id: 43, color: "black", Piece: null },
        { CoordinatePosition: "F5", Id: 44, color: "white", Piece: null },
        { CoordinatePosition: "F6", Id: 45, color: "black", Piece: null },
        {
          CoordinatePosition: "F7",
          Id: 46,
          color: "white",
          Piece: { Player: 2, color: "black", PieceType: "Pawn" },
        },
        {
          CoordinatePosition: "F8",
          Id: 47,
          color: "black",
          Piece: { Player: 2, color: "black", PieceType: "Bishop" },
        },
        {
          CoordinatePosition: "G1",
          Id: 48,
          color: "black",
          Piece: { Player: 1, color: "white", PieceType: "Knight" },
        },
        {
          CoordinatePosition: "G2",
          Id: 49,
          color: "white",
          Piece: { Player: 1, color: "white", PieceType: "Pawn" },
        },
        { CoordinatePosition: "G3", Id: 50, color: "black", Piece: null },
        { CoordinatePosition: "G4", Id: 51, color: "white", Piece: null },
        { CoordinatePosition: "G5", Id: 52, color: "black", Piece: null },
        { CoordinatePosition: "G6", Id: 53, color: "white", Piece: null },
        {
          CoordinatePosition: "G7",
          Id: 54,
          color: "black",
          Piece: { Player: 2, color: "black", PieceType: "Pawn" },
        },
        {
          CoordinatePosition: "G8",
          Id: 55,
          color: "white",
          Piece: { Player: 2, color: "black", PieceType: "Knight" },
        },
        {
          CoordinatePosition: "H1",
          Id: 56,
          color: "white",
          Piece: { Player: 1, color: "white", PieceType: "Rook" },
        },
        {
          CoordinatePosition: "H2",
          Id: 57,
          color: "black",
          Piece: { Player: 1, color: "white", PieceType: "Pawn" },
        },
        { CoordinatePosition: "H3", Id: 58, color: "white", Piece: null },
        { CoordinatePosition: "H4", Id: 59, color: "black", Piece: null },
        { CoordinatePosition: "H5", Id: 60, color: "white", Piece: null },
        { CoordinatePosition: "H6", Id: 61, color: "black", Piece: null },
        {
          CoordinatePosition: "H7",
          Id: 62,
          color: "white",
          Piece: { Player: 2, color: "black", PieceType: "Pawn" },
        },
        {
          CoordinatePosition: "H8",
          Id: 63,
          color: "black",
          Piece: { Player: 2, color: "black", PieceType: "Rook" },
        },
      ],
    };
  },
  computed: {
    OneSquares() {
      return this.squares.filter((s) => s.CoordinatePosition.includes("1"));
    },
    TwoSquares() {
      return this.squares.filter((s) => s.CoordinatePosition.includes("2"));
    },
    ThreeSquares() {
      return this.squares.filter((s) => s.CoordinatePosition.includes("3"));
    },
    FourSquares() {
      return this.squares.filter((s) => s.CoordinatePosition.includes("4"));
    },
    FiveSquares() {
      return this.squares.filter((s) => s.CoordinatePosition.includes("5"));
    },
    SixSquares() {
      return this.squares.filter((s) => s.CoordinatePosition.includes("6"));
    },
    SevenSquares() {
      return this.squares.filter((s) => s.CoordinatePosition.includes("7"));
    },
    EightSquares() {
      return this.squares.filter((s) => s.CoordinatePosition.includes("8"));
    },
  },
};
</script>
<template>
  <div class="chess-board-container">
    <table class="chess-board">
      <tbody>
        <tr>
          <th></th>
          <th>A</th>
          <th>B</th>
          <th>C</th>
          <th>D</th>
          <th>E</th>
          <th>F</th>
          <th>G</th>
          <th>H</th>
        </tr>
        <tr>
          <th>8</th>
          <Square v-for="square in EightSquares" :key="square.Id" v-bind:pieceType="square.Piece != null ? square.Piece.color + square.Piece.PieceType : null" v-bind:squareColor="square.color"/>
        </tr>
        <tr>
          <th>7</th>
          <Square v-for="square in SevenSquares" :key="square.Id" v-bind:pieceType="square.Piece != null ? square.Piece.color + square.Piece.PieceType : null" v-bind:squareColor="square.color"/>
        </tr>
        <tr>
          <th>6</th>
          <Square v-for="square in SixSquares" :key="square.Id" v-bind:pieceType="square.Piece != null ? square.Piece.color + square.Piece.PieceType : null" v-bind:squareColor="square.color"/>
        </tr>
        <tr>
          <th>5</th>
          <Square v-for="square in FiveSquares" :key="square.Id" v-bind:pieceType="square.Piece != null ? square.Piece.color + square.Piece.PieceType : null" v-bind:squareColor="square.color"/>
        </tr>
        <tr>
          <th>4</th>
          <Square v-for="square in FourSquares" :key="square.Id" v-bind:pieceType="square.Piece != null ? square.Piece.color + square.Piece.PieceType : null" v-bind:squareColor="square.color"/>
        </tr>
        <tr>
          <th>3</th>
          <Square v-for="square in ThreeSquares" :key="square.Id" v-bind:pieceType="square.Piece != null ? square.Piece.color + square.Piece.PieceType : null" v-bind:squareColor="square.color"/>
        </tr>
        <tr>
          <th>2</th>
          <Square v-for="square in TwoSquares" :key="square.Id" v-bind:pieceType="square.Piece != null ? square.Piece.color + square.Piece.PieceType : null" v-bind:squareColor="square.color"/>
        </tr>
        <tr>
          <th>1</th>
          <Square v-for="square in OneSquares" :key="square.Id" v-bind:pieceType="square.Piece != null ? square.Piece.color + square.Piece.PieceType : null" v-bind:squareColor="square.color"/>
        </tr>
      </tbody>
    </table>
  </div>
</template>

<style scoped>
.chess-board-container {
  padding-top: 3vh;
  display: flex;
  justify-content: center;
  background: white;
}
.chess-board {
  border-spacing: 0;
  border-collapse: collapse;
}
.chess-board th {
  padding: 0.5em;
}
.chess-board th + th {
  border-bottom: 1px solid #000;
}
.chess-board th:first-child,
.chess-board td:last-child {
  border-right: 1px solid #000;
}
.chess-board tr:last-child td {
  border-bottom: 1px solid;
}
.chess-board th:empty {
  border: none;
}
.chess-board td {
  width: 2em;
  height: 2em;
  text-align: center;
  font-size: 48px;
  line-height: 0;
}
.chess-board .white {
  background: #eee;
}
.chess-board .black {
  background: #aaa;
}
</style>