<script>
export default {
  name: "Sqaure",
  props: {
    pieceType: String,
    squareColor: String
  },
  data() {
    return {};
  },
  computed: {
    fileName() {
      return "../../src/assets/images/" + this.pieceType + ".svg";
    }

  }
}
</script>
<template>
  <td :class="squareColor"><img :src="fileName" alt=""/></td>
 
</template>

<style scoped>

</style>