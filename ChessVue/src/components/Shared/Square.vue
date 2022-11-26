<script>
export default {
  name: "Sqaure",
  props: {
    fileName: String,
    squareColor: String
  },
  data() {
    return {};
  },
  computed: {
    getFileName() {
      return "../../src/assets/images/" + this.fileName + ".svg";
    }

  }
}
</script>
<template>
  <td :class="squareColor"><img :src="getFileName" alt=""/></td>
 
</template>

<style scoped>

</style>