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

  }
}
</script>
<template>
  <td :class="squareColor"><img :src="getFileName" alt=""/></td>
 
</template>

<style scoped>

</style>