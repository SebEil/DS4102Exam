<template>
  <header>
    <nav>
      <p class="logo"> Army Parmesany </p>
      <ul v-show="!mobile" class="navigation">
        <li> <router-link to="/">Home</router-link> </li>
        <li> <router-link to="/about">About</router-link> </li>
        <li> <router-link to="/overview">Army</router-link> </li>
        <li> <router-link to="/admin">Admin</router-link> </li>
      </ul>
      <div class="icon">
        <i @click="toggleMobileNav" v-show="mobile" class="fas fa-bars" :class="{ 'icon-active': mobileNav }"></i>
      </div>
      <transition name="mobile-navigation">
        <ul v-show="mobileNav" class="drop-menu">
          <li> <router-link to="/">Home</router-link> </li>
          <li> <router-link to="/about">About</router-link> </li>
          <li> <router-link to="/overview">Army</router-link> </li>
          <li> <router-link to="/admin">Admin</router-link> </li>
        </ul>
      </transition>
    </nav>
  </header>
</template>

<script>
export default {
  name: "navigation",
  data() {
    return{
      mobile: null,
      mobileNav: null,
      windowWidth: null
    };
  },
  created() {
    window.addEventListener('resize', this.checkScreen);
    this.checkScreen();
  },
  methods: {
    toggleMobileNav(){
      this.mobileNav = !this.mobileNav
    },
    
    checkScreen(){
      this.windowWidth = window.innerWidth;
      if(this.windowWidth <= 1150){
        this.mobile = true;
        return;
      }
      this.mobile = false;
      this.mobileNav = false;
      return;
    }
  }
}
</script>


<style>

header {
  z-index: 99;
  width: 100%;
  background: black;
}

nav {
  padding: 20px;
  margin-bottom: 30px;
  display: flex;
  justify-content: space-between;
}

.navigation {
  display: flex;
  align-items: center;
  list-style: none;
  padding-left: 500px;
}

li a{
  font-weight: bold;
  padding: 20px;
  text-decoration: none;
  color: white;
  list-style: none;
}

li a:hover{
  border-bottom: 1px solid #ffffff;
  color: white;

}

nav a.router-link-exact-active {
  color: #42b983;
  border-bottom: 1px solid #42b983;
}

.logo{
  text-transform: uppercase;
  padding: 10px;
  font-size: 20px;
  color: #42b983;
}

i{
  font-size: 40px;
  color: #42b983;
  cursor: pointer;
  transition: 0.8s ease all;
}

i:hover{
  transform: rotate(90deg);
  transition: 0.5s ease all;
  color: #FFF;
}

.drop-menu{
  display: flex;
  flex-direction: column;
  position: fixed;
  width: 100%;
  max-width: 250px;
  height: 100%;
  background-color:  black;
  top: 0;
  left: 0;
}

ul, a.router-link-exact-active{
  list-style: none;
}

.drop-menu, li{
  justify-content: space-evenly;
}

.mobile-navigation-enter-active,
.mobile-navigation-leave-active{
  transition: 1s ease all;
}

.mobile-navigation-enter-from,
.mobile-navigation-leave-to {
  transform: translateX(-250px);
}

.mobile-navigation-enter-to {
  transform: translateX(0);
}


</style>