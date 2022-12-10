<template>
  <div id="app">
     <Nav/>
     <div class="marginPrincial">
      <Knight/>
      <!-- <router-link></router-link> -->
     </div>
     <Hall/>  
     <!-- <Sobre/>   -->
  
  </div>
</template>

<script>
import Nav from './components/Nav.vue'
import Knight from './components/Knight.vue'
import Hall from './components/Hall.vue'
// import Sobre from './components/Sobre.vue'

export default {
  name: 'App',
  components: {
    Nav,
    Knight,
    Hall
    // ,
    // Sobre
  }
}
</script>

<style>
@import url("https://fonts.googleapis.com/css?family=Montserrat:400,700");
body{
  background-color: #eee;
  font-family: "Montserrat", sans-serif;
  display: grid;
  justify-items: center;
}
body, html {
  margin: 0;
  height: 100%;
}

#app {
  width: 100%;
}

table {
  margin: 0px;
  padding: 0px;
  list-style-type: none;
  width: 100%;
}
table tr td{
  padding: 20px;
  font-size: 1.3em;
  background-color: #e0edf4;
  margin-bottom: 2px;
  color: #3e5252;
}
table thead th{
  background-color: rgb(184, 208, 216) !important;
  font-size: 1.2em;
  padding: 10px 0px;
  text-align: center !important;
}
.colPequeno {
  width: 5%;
}

.btnDanger{
  background-color: #fa4430;
    
}
.btnFind{
  background-color: aquamarine;

}
.btn{
  
  padding: 10px 20px;
  cursor: pointer;
  color: white;
  border: 1px solid #000;
  font-weight: bold;
  border-radius: 5px;
  border-bottom: 3px solid black;
}
.btn:hover{
  text-shadow: 1px 1px 1px black;
  margin-top: 3px;
  border-bottom: 1px solid black;
}

.marginPrincial{
  widows: 50%;
}
</style>

