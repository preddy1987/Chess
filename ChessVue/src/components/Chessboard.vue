<script setup>
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
          <td class="light">♜</td>
          <td class="dark">♞</td>
          <td class="light">♝</td>
          <td class="dark">♛</td>
          <td class="light">♚</td>
          <td class="dark">♝</td>
          <td class="light">♞</td>
          <td class="dark">♜</td>
        </tr>
        <tr>
          <th>7</th>
          <td class="dark">♟</td>
          <td class="light">♟</td>
          <td class="dark">♟</td>
          <td class="light">♟</td>
          <td class="dark">♟</td>
          <td class="light">♟</td>
          <td class="dark">♟</td>
          <td class="light">♟</td>
        </tr>
        <tr>
          <th>6</th>
          <td class="light"></td>
          <td class="dark"></td>
          <td class="light"></td>
          <td class="dark"></td>
          <td class="light"></td>
          <td class="dark"></td>
          <td class="light"></td>
          <td class="dark"></td>
        </tr>
        <tr>
          <th>5</th>
          <td class="dark"></td>
          <td class="light"></td>
          <td class="dark"></td>
          <td class="light"></td>
          <td class="dark"></td>
          <td class="light"></td>
          <td class="dark"></td>
          <td class="light"></td>
        </tr>
        <tr>
          <th>4</th>
          <td class="light"></td>
          <td class="dark"></td>
          <td class="light"></td>
          <td class="dark"></td>
          <td class="light"></td>
          <td class="dark"></td>
          <td class="light"></td>
          <td class="dark"></td>
        </tr>
        <tr>
          <th>3</th>
          <td id="a3" class="dark"></td>
          <td id="b3" class="light"></td>
          <td id="c3" class="dark"></td>
          <td id="d3" class="light"></td>
          <td id="e3" class="dark"></td>
          <td id="f3" class="light"></td>
          <td id="g3" class="dark"></td>
          <td id="h3" class="light"></td>
        </tr>
        <tr>
          <th>2</th>
          <td id="a2" class="light">♙</td>
          <td id="b2" class="dark">♙</td>
          <td id="c2" class="light">♙</td>
          <td id="d2" class="dark">♙</td>
          <td id="e2" class="light">♙</td>
          <td id="f2" class="dark">♙</td>
          <td id="g2" class="light">♙</td>
          <td id="h2" class="dark">♙</td>
        </tr>
        <tr>
          <th>1</th>
          <td id="a1" class="dark">♖</td>
          <td id="b1" class="light">♘</td>
          <td id="c1" class="dark">♗</td>
          <td id="d1" class="light">♕</td>
          <td id="e1" class="dark">♔</td>
          <td id="f1" class="light">♗</td>
          <td id="g1" class="dark">♘</td>
          <td id="h1" class="light">♖</td>
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
  font-size: 64px;
  line-height: 0;
}
.chess-board .light {
  background: #eee;
}
.chess-board .dark {
  background: #aaa;
}
</style>