<template>

  <div>
    <Titulo msg="KNIGHTS"/>
    <input type="text"  placeholder="Id" v-model="nome" v-on:keyup.enter="findId()"/>
    <button class="btn btnFind btnInput" v-on:click="findId()">CONSULTAR</button>
    <table>
      <thead>
        <th>Id</th>
        <th>NOME</th>
        <th>IDADE</th>
        <th>ARMAS</th>
        <th>ATRIBUTO</th>
        <th>ATAQUE</th>
        <th>EXP</th>
        <th>OPÇÕES</th>
      </thead>
      <tbody>
        <tr v-for="(item, index) in knights" :key="index">
          <td>{{item.id}}</td>
          <td>{{item.name}}</td>
          <td>{{item.idade}}</td>
          <td>{{item.armas}}</td>
          <td>{{item.atributo}}</td>
          <td>{{item.ataque}}</td>
          <td>{{item.exp}}</td>
          <td>
            <button class="btn btnDanger" @click="remover(item)">Remover</button>
          </td>
        </tr>
      </tbody>
      <tfoot v-if="knights.length <= 0">
        <tr>
          <td colspan="8" style="text-align: center;">Sem Heores</td>
        </tr>
      </tfoot>
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
    titulo: "Knight",
    nome: "",
    knights: []
    }
  },
  created(){
      this.getAll()
  },
 methods: {
  findId(){
    if(this.nome !==  "")
      {
        let _knight  = {
            id: this.nome
          }
          this.$http
          .get(`https://localhost:44398/Knight/${_knight.id}`)
          .then(res=> res.json())
          .then(knightss => this.knights = knightss)
          this.nome = "";
      }
      else{
        this.getAll();
      }  
},
  getAll(){
    this.$http
      .get('https://localhost:44398/Knight')
      .then(res=> res.json())
      .then(knightss => this.knights = knightss)
  },
    remover(knight) {
    this.$http
      .delete(`https://localhost:44398/Knight/${knight.id}`)
      .then(()=>{
          let indice = this.knights.indexOf(knight);
          this.knights.splice(indice, 1)
      })
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
