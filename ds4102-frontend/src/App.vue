<template>
  <Navbar/>
  <router-view/>
</template>

<script>

import Navbar from "./components/shared/Navbar.vue"
export default {
  components: {
    Navbar,
  }
}
</script>


<style>

*{
  box-sizing: border-box;
  padding: 0;
  margin: 0;
}

#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased; 
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}

</style>
