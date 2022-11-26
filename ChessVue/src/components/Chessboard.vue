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
          color: "light",
          Piece: { Player: 1, color: "white", PieceType: "Rook" },
        },
        {
          CoordinatePosition: "A2",
          Id: 1,
          color: "dark",
          Piece: { Player: 1, color: "white", PieceType: "Pawn" },
        },
        { CoordinatePosition: "A3", Id: 2, color: "light", Piece: null },
        { CoordinatePosition: "A4", Id: 3, color: "dark", Piece: null },
        { CoordinatePosition: "A5", Id: 4, color: "light", Piece: null },
        { CoordinatePosition: "A6", Id: 5, color: "dark", Piece: null },
        {
          CoordinatePosition: "A7",
          Id: 6,
          color: "light",
          Piece: { Player: 2, color: "black", PieceType: "Pawn" },
        },
        {
          CoordinatePosition: "A8",
          Id: 7,
          color: "dark",
          Piece: { Player: 2, color: "black", PieceType: "Rook" },
        },
        {
          CoordinatePosition: "B1",
          Id: 8,
          color: "dark",
          Piece: { Player: 1, color: "white", PieceType: "Knight" },
        },
        {
          CoordinatePosition: "B2",
          Id: 9,
          color: "light",
          Piece: { Player: 1, color: "white", PieceType: "Pawn" },
        },
        { CoordinatePosition: "B3", Id: 10, color: "dark", Piece: null },
        { CoordinatePosition: "B4", Id: 11, color: "light", Piece: null },
        { CoordinatePosition: "B5", Id: 12, color: "dark", Piece: null },
        { CoordinatePosition: "B6", Id: 13, color: "light", Piece: null },
        {
          CoordinatePosition: "B7",
          Id: 14,
          color: "dark",
          Piece: { Player: 2, color: "black", PieceType: "Pawn" },
        },
        {
          CoordinatePosition: "B8",
          Id: 15,
          color: "light",
          Piece: { Player: 2, color: "black", PieceType: "Knight" },
        },
        {
          CoordinatePosition: "C1",
          Id: 16,
          color: "light",
          Piece: { Player: 1, color: "white", PieceType: "Bishop" },
        },
        {
          CoordinatePosition: "C2",
          Id: 17,
          color: "dark",
          Piece: { Player: 1, color: "white", PieceType: "Pawn" },
        },
        { CoordinatePosition: "C3", Id: 18, color: "light", Piece: null },
        { CoordinatePosition: "C4", Id: 19, color: "dark", Piece: null },
        { CoordinatePosition: "C5", Id: 20, color: "light", Piece: null },
        { CoordinatePosition: "C6", Id: 21, color: "dark", Piece: null },
        {
          CoordinatePosition: "C7",
          Id: 22,
          color: "light",
          Piece: { Player: 2, color: "black", PieceType: "Pawn" },
        },
        {
          CoordinatePosition: "C8",
          Id: 23,
          color: "dark",
          Piece: { Player: 2, color: "black", PieceType: "Bishop" },
        },
        {
          CoordinatePosition: "D1",
          Id: 24,
          color: "dark",
          Piece: { Player: 1, color: "white", PieceType: "Queen" },
        },
        {
          CoordinatePosition: "D2",
          Id: 25,
          color: "light",
          Piece: { Player: 1, color: "white", PieceType: "Pawn" },
        },
        { CoordinatePosition: "D3", Id: 26, color: "dark", Piece: null },
        { CoordinatePosition: "D4", Id: 27, color: "light", Piece: null },
        { CoordinatePosition: "D5", Id: 28, color: "dark", Piece: null },
        { CoordinatePosition: "D6", Id: 29, color: "light", Piece: null },
        {
          CoordinatePosition: "D7",
          Id: 30,
          color: "dark",
          Piece: { Player: 2, color: "black", PieceType: "Pawn" },
        },
        {
          CoordinatePosition: "D8",
          Id: 31,
          color: "light",
          Piece: { Player: 2, color: "black", PieceType: "Queen" },
        },
        {
          CoordinatePosition: "E1",
          Id: 32,
          color: "light",
          Piece: { Player: 1, color: "white", PieceType: "King" },
        },
        {
          CoordinatePosition: "E2",
          Id: 33,
          color: "dark",
          Piece: { Player: 1, color: "white", PieceType: "Pawn" },
        },
        { CoordinatePosition: "E3", Id: 34, color: "light", Piece: null },
        { CoordinatePosition: "E4", Id: 35, color: "dark", Piece: null },
        { CoordinatePosition: "E5", Id: 36, color: "light", Piece: null },
        { CoordinatePosition: "E6", Id: 37, color: "dark", Piece: null },
        {
          CoordinatePosition: "E7",
          Id: 38,
          color: "light",
          Piece: { Player: 2, color: "black", PieceType: "Pawn" },
        },
        {
          CoordinatePosition: "E8",
          Id: 39,
          color: "dark",
          Piece: { Player: 2, color: "black", PieceType: "King" },
        },
        {
          CoordinatePosition: "F1",
          Id: 40,
          color: "dark",
          Piece: { Player: 1, color: "white", PieceType: "Bishop" },
        },
        {
          CoordinatePosition: "F2",
          Id: 41,
          color: "light",
          Piece: { Player: 1, color: "white", PieceType: "Pawn" },
        },
        { CoordinatePosition: "F3", Id: 42, color: "dark", Piece: null },
        { CoordinatePosition: "F4", Id: 43, color: "light", Piece: null },
        { CoordinatePosition: "F5", Id: 44, color: "dark", Piece: null },
        { CoordinatePosition: "F6", Id: 45, color: "light", Piece: null },
        {
          CoordinatePosition: "F7",
          Id: 46,
          color: "dark",
          Piece: { Player: 2, color: "black", PieceType: "Pawn" },
        },
        {
          CoordinatePosition: "F8",
          Id: 47,
          color: "light",
          Piece: { Player: 2, color: "black", PieceType: "Bishop" },
        },
        {
          CoordinatePosition: "G1",
          Id: 48,
          color: "light",
          Piece: { Player: 1, color: "white", PieceType: "Knight" },
        },
        {
          CoordinatePosition: "G2",
          Id: 49,
          color: "dark",
          Piece: { Player: 1, color: "white", PieceType: "Pawn" },
        },
        { CoordinatePosition: "G3", Id: 50, color: "light", Piece: null },
        { CoordinatePosition: "G4", Id: 51, color: "dark", Piece: null },
        { CoordinatePosition: "G5", Id: 52, color: "light", Piece: null },
        { CoordinatePosition: "G6", Id: 53, color: "dark", Piece: null },
        {
          CoordinatePosition: "G7",
          Id: 54,
          color: "light",
          Piece: { Player: 2, color: "black", PieceType: "Pawn" },
        },
        {
          CoordinatePosition: "G8",
          Id: 55,
          color: "dark",
          Piece: { Player: 2, color: "black", PieceType: "Knight" },
        },
        {
          CoordinatePosition: "H1",
          Id: 56,
          color: "dark",
          Piece: { Player: 1, color: "white", PieceType: "Rook" },
        },
        {
          CoordinatePosition: "H2",
          Id: 57,
          color: "light",
          Piece: { Player: 1, color: "white", PieceType: "Pawn" },
        },
        { CoordinatePosition: "H3", Id: 58, color: "dark", Piece: null },
        { CoordinatePosition: "H4", Id: 59, color: "light", Piece: null },
        { CoordinatePosition: "H5", Id: 60, color: "dark", Piece: null },
        { CoordinatePosition: "H6", Id: 61, color: "light", Piece: null },
        {
          CoordinatePosition: "H7",
          Id: 62,
          color: "dark",
          Piece: { Player: 2, color: "black", PieceType: "Pawn" },
        },
        {
          CoordinatePosition: "H8",
          Id: 63,
          color: "light",
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
          <th>a</th>
          <th>b</th>
          <th>c</th>
          <th>d</th>
          <th>e</th>
          <th>f</th>
          <th>g</th>
          <th>h</th>
        </tr>
        <tr>
          <th>8</th>
          <Square v-for="square in EightSquares" :key="square.Id" v-bind:fileName="square.Piece != null ? square.Piece.color + square.Piece.PieceType : null" v-bind:squareColor="square.color"/>
        </tr>
        <tr>
          <th>7</th>
          <Square v-for="square in SevenSquares" :key="square.Id" v-bind:fileName="square.Piece != null ? square.Piece.color + square.Piece.PieceType : null" v-bind:squareColor="square.color"/>
        </tr>
        <tr>
          <th>6</th>
          <Square v-for="square in SixSquares" :key="square.Id" v-bind:fileName="square.Piece != null ? square.Piece.color + square.Piece.PieceType : null" v-bind:squareColor="square.color"/>
        </tr>
        <tr>
          <th>5</th>
          <Square v-for="square in FiveSquares" :key="square.Id" v-bind:fileName="square.Piece != null ? square.Piece.color + square.Piece.PieceType : null" v-bind:squareColor="square.color"/>
        </tr>
        <tr>
          <th>4</th>
          <Square v-for="square in FourSquares" :key="square.Id" v-bind:fileName="square.Piece != null ? square.Piece.color + square.Piece.PieceType : null" v-bind:squareColor="square.color"/>
        </tr>
        <tr>
          <th>3</th>
          <Square v-for="square in ThreeSquares" :key="square.Id" v-bind:fileName="square.Piece != null ? square.Piece.color + square.Piece.PieceType : null" v-bind:squareColor="square.color"/>
        </tr>
        <tr>
          <th>2</th>
          <Square v-for="square in TwoSquares" :key="square.Id" v-bind:fileName="square.Piece != null ? square.Piece.color + square.Piece.PieceType : null" v-bind:squareColor="square.color"/>
        </tr>
        <tr>
          <th>1</th>
          <Square v-for="square in OneSquares" :key="square.Id" v-bind:fileName="square.Piece != null ? square.Piece.color + square.Piece.PieceType : null" v-bind:squareColor="square.color"/>
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
.chess-board .light {
  background: #eee;
}
.chess-board .dark {
  background: #aaa;
}
</style>