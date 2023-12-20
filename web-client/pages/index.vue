<template>
  {{message}}
</template>

<script>
import Axios from 'axios';
export default {
name: "index",
  data: () => ({
    message: "No way"
  }),
  asyncData() {
   return Axios.get("http://localhost:5098/api/home")
        .then(data => {
          return {message: data}
        })
  }
}
</script>
<style scoped>

</style>