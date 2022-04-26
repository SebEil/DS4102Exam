<template>
    <section>
        <h2>List of soldiers</h2>
        <article class="row align d-flex justify-content-center">
        <soldier-item
            class="container col p-2 text-center" v-for="(soldier, i) in soldiers"
            :key="i"
            :SoldierId="soldier.SoldierId"
            :SoldierName="soldier.SoldierName"
            :Bloodtype="soldier.Bloodtype"
            :Height="soldier.Height"
            :image="soldier.image"
            :IsOnMission="soldier.IsOnMission">
            </soldier-item>
        </article>
    </section>
</template>

<script>
import SoldierItem from "../soldiers/SoldierItem.vue"
import soldierService from "../../services/soldierService.js"

export default {
    setup(){
        const soldiers = soldierService.getAllSoldiers();

        return{
            soldiers
        }
    },
    components: {
        SoldierItem
    }   
}
</script>

<style>
    .container{
        padding: 1rem;
        background-color: rgb(161, 148, 148);
        border-radius: 25px;
        margin-bottom: 1rem;
        display: inline-block;
    }


</style>