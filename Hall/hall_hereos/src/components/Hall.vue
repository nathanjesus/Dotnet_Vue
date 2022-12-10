<template>
  <div>
      <Titulo msg="HALL"/>
    <table>
      <thead>
         <th>Id</th>
        <th>NOME</th>
        <th>IDADE</th>
        <th>ARMAS</th>
        <th>ATRIBUTO</th>
        <th>ATAQUE</th>
        <th>EXP</th>
      </thead>
      <tbody>
        <tr v-for="(item, index) in hall" :key="index">
    <td>{{item.id}}</td>
          <td>{{item.name}}</td>
          <td>{{item.idade}}</td>
          <td>{{item.armas}}</td>
          <td>{{item.atributo}}</td>
          <td>{{item.ataque}}</td>
          <td>{{item.exp}}</td>
        </tr>
      </tbody>
      <tfoot v-if="hall.length <= 0"> Sem Heores</tfoot>
    </table> 
  </div>
</template>

<script>
import Titulo from './Titulo.vue'
export default {
      components: {
      Titulo    
  },
  props: {
    msg: String
  },
  data() {
    return {
    titulo: "Hall",
    nome: "",
    hall: []
    }
  },
  created(){
      this.getAll()
  },
 methods: {
   getAll(){
    this.$http
      .get('https://localhost:44398/Hall/')
      .then(res=> res.json())
      .then(knightss => this.hall = knightss)
  }
 },

}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
input{
  width: calc(100% - 195px);
  border: 0;
  padding: 20px;
  font-size: 1.3em;
  color: #687f7f;
  display: inline;
}
.btnInput{
  width: 150px;
  border: 0;
  padding: 20px;
  font-size: 1.3em;
  background-color: rgb(116,115,115);
  display: inline;
}
.btn:hover{
  padding: 20px;
  margin: 0px;
  border: 0px;
}
</style>
