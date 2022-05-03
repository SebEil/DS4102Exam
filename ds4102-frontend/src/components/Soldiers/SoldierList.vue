<template>
    <section>
        <h2 class="spacingTop">Soldiers</h2>
        <article class="row align d-flex justify-content-center">
        <soldier-item
           class="container col p-2 text-center" v-for="(soldier, i) in soldiers"
            :key="i"
            :image="soldier.image"
            :soldierId="soldier.soldierId"
            :soldierName="soldier.soldierName"
            :bloodtype="soldier.bloodtype"
            :height="soldier.height"
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