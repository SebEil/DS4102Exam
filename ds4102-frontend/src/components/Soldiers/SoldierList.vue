<template>
    <section>
        <article class="row align d-flex justify-content-center">
        <soldier-item
            class="container col p-2 text-center" v-for="(soldier, i) in soldiers"
            :key="i"
            :soldierId="soldier.soldierId"
            :soldierName="soldier.soldierName"
            :bloodtype="soldier.bloodtype"
            :height="soldier.height"
            :image="soldier.image"
            :isOnMission="soldier.isOnMission">
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
    img{
        width: 320px;
        height: 320px;   
    }

    .container{
        padding: 1rem;
        background-color: rgb(161, 148, 148);
        border-radius: 25px;
        margin-bottom: 1rem;
        display: inline-block;
    }


</style>