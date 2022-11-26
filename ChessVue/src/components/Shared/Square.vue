<script>
export default {
  props: {
    fileName: String,
    squareColor: String
  },
  // ['fileName','sqaureColor'],
  // components: {
  //   Square,
  // },
  data() {
    return {};
  },
  computed: {
    getFileName() {
      return "../../src/assets/images/" + this.fileName + ".svg";
    }
    // getSquareColor() {

    // }
  }
}
</script>
<template>
  <td :class="squareColor"><img :src="getFileName" alt=""/></td>
 
</template>

<style scoped>
/* .chess-board-container {
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
} */
</style>